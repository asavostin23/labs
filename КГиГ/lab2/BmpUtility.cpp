#include "stdafx.h"
#include "BmpUtility.h"

HBITMAP LoadBmp(CString fileName)
{
	HBITMAP hBmp = (HBITMAP)LoadImage(NULL,
		fileName,
		IMAGE_BITMAP, 0, 0, //SIZE
		LR_LOADFROMFILE | LR_CREATEDIBSECTION);
	return hBmp;
}

void ShowBmp(HWND hWindow, HBITMAP hBmp, int x, int y)
{
	BITMAP bmp; //��� ����� ��������� ���� � ���� �����
	GetObject(hBmp,// ��� ���� bmp
		sizeof(BITMAP), //������ �������
		(LPSTR)&bmp); //��������� � ������� ������ � �������� ���� ����

	HDC dcDisplay = GetDC(hWindow);
	HDC dcMemory = CreateCompatibleDC(dcDisplay);//�������  �������� ������ ����������� � ���������� �����������

	HBITMAP oldBmp = (HBITMAP)SelectObject(dcMemory, hBmp);  // �������� ����������� bitmap � �������� ������

	BitBlt(//������ �����������
		dcDisplay, x, y, //� ���� � � ����� ����������� � ������� �������
		bmp.bmWidth, bmp.bmHeight, //������� �����������
		dcMemory,
		0, 0, 
		SRCCOPY); //�������� ��������(��� ��������� ��������)

	SelectObject(dcMemory, oldBmp);    // ��������������� �������� ������

	ReleaseDC(hWindow, dcDisplay); //����������� ���������� �����
	DeleteDC(dcMemory);// ������� �������� ������
}

void SaveBmp(HWND hWindow, RECT& area, CString fileName)
{
	HDC dcDisplay = GetDC(hWindow);
	HDC dcMemory = CreateCompatibleDC(dcDisplay);//�������  �������� ������ ����������� � ���������� �����������

	HBITMAP hBmp = CreateCompatibleBitmap(dcDisplay, //�������� ��������� �������
		abs(area.right - area.left),//������ ������ �������
		abs(area.bottom - area.top));
	HBITMAP hOldBmp = (HBITMAP)SelectObject(dcMemory, hBmp); // �������� ����������� bitmap � �������� ������
	BitBlt(//������ �����������
		dcMemory, 0, 0, //� ���� � � ����� ����������� � ������� �������
		abs(area.right - area.left), abs(area.bottom - area.top), //������� �����������
		dcDisplay,
		area.left, area.top, //� ���� � � ����� ����������� � �������� �������
		SRCCOPY);//�������� ��������(��� ��������� ��������)


	hBmp = (HBITMAP)SelectObject(dcMemory, hOldBmp);// ��������������� �������� ������

	BITMAP bmp;
	BITMAPINFOHEADER bmpInfoHeader;
	BITMAPFILEHEADER bmpFileHeader; 
	int colorDepth = 32; //������� �����

	GetObject(hBmp, sizeof(BITMAP), (LPSTR)&bmp);// �������� ������

	bmpInfoHeader.biSize = sizeof(BITMAPINFOHEADER);//����������� ���� ����������� ���������
	bmpInfoHeader.biWidth = abs(bmp.bmWidth);//������
	bmpInfoHeader.biHeight = abs(bmp.bmHeight);//������
	bmpInfoHeader.biPlanes = 1;//����������� ����� ��� �������� ����������
	bmpInfoHeader.biBitCount = colorDepth; //����� ����� �� ������ - ������� �����
	bmpInfoHeader.biCompression = BI_RGB; //��� ������(����� �������, �������� �� png ��� jpeg), ��� ��� ������
	bmpInfoHeader.biSizeImage = 0; //������ �����������, ��� BI_RGB 0, �� ��� ������, ���� ������ ������, �� ��� ������ �� ��������� ��������
	bmpInfoHeader.biXPelsPerMeter = 0; //���������� � �������� �� ���� �������� ���������� ��� ���������� �����������
	bmpInfoHeader.biYPelsPerMeter = 0;
	bmpInfoHeader.biClrUsed = 0; //���������� �������� �������� � ������� ������ ������������. ���� ����� ����, �� ����� ���� �����
	bmpInfoHeader.biClrImportant = 0; //���������� �������� ��������, ����������� ��� ����������� ���������� �����������. ����  ����, ��� �����.

	DWORD dwBitSize = ((bmp.bmWidth * colorDepth + 31) / 32) *
		4 * bmp.bmHeight; //������� ������
	DWORD dwDibSize = sizeof(BITMAPFILEHEADER) +
		sizeof(BITMAPINFOHEADER) +
		dwBitSize;

	bmpFileHeader.bfType = ('M' << 8) | 'B'; //��� �����
	bmpFileHeader.bfSize = dwDibSize; //������ � ������ ����� ���������� �����������.
	bmpFileHeader.bfReserved1 = 0; //�����������������
	bmpFileHeader.bfReserved2 = 0;
	bmpFileHeader.bfOffBits = (DWORD)sizeof(BITMAPFILEHEADER) +
		(DWORD)sizeof(BITMAPINFOHEADER); //�������� � ������ �� ������ ��������� � ����� ������� �����.

	HANDLE hDib = GlobalAlloc(//�������� ���������� ���� ������
		GHND, //�� ��� ����� ����� ������������ ������� �������� � ������������ ������������ ���� ������. ���������� ����� ������������� ����� ������ ����� ����������
		dwBitSize + sizeof(BITMAPINFOHEADER));//���������� ������
	LPBITMAPINFOHEADER lpBmpInfoHeader = (LPBITMAPINFOHEADER)GlobalLock(hDib); //�������� ������ ��� ��������� BITMAPINFOHEADER �������� ���������� � �������� � �������� ������� DIB(BMP).
	*lpBmpInfoHeader = bmpInfoHeader;

	GetDIBits(//��������� ���� ��������� ������������ ��������� ������� � �������� �� � ����� ��� DIB
		dcMemory,
		hBmp,  // ���������� �������
		0, // ������ ��������������� ������ ���������
		(UINT)bmp.bmHeight,  // ����� ���������� ����� ���������
		(LPSTR)lpBmpInfoHeader + sizeof(BITMAPINFOHEADER), // ������ ��� ����� �������
		(BITMAPINFO*)lpBmpInfoHeader, // ����� ������ �������
		DIB_RGB_COLORS);// ������� RGB ��� �������

	HANDLE hFile = CreateFile(fileName, GENERIC_WRITE, 0, NULL,
		CREATE_ALWAYS, FILE_ATTRIBUTE_NORMAL |
		FILE_FLAG_SEQUENTIAL_SCAN, NULL);
	if (hFile == INVALID_HANDLE_VALUE)
	{
		MessageBox(NULL, L"�� ������� ������� ����", L"������", MB_ICONSTOP);
		return;
	}

	DWORD dwWritten;

	WriteFile(hFile, // ���������� �����
		(LPSTR)&bmpFileHeader, // ����� ������
		sizeof(BITMAPFILEHEADER),// ����� ������ ��� ������
		&dwWritten, // ����� ���������� ������
		NULL);// ����������� �����
	WriteFile(hFile, (LPSTR)lpBmpInfoHeader, dwDibSize,
		&dwWritten, NULL);

	GlobalUnlock(hDib);//����� ������������ ������
	GlobalFree(hDib);
	CloseHandle(hFile);

	ReleaseDC(hWindow, dcDisplay);
	DeleteDC(dcMemory);

	if (dwWritten == 0)
	{
		MessageBox(NULL, L"�� ������� �������� ����", L"������", MB_ICONSTOP);
		return;
	}
}