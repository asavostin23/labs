#include "stdafx.h"
#include "CMatrix.h"
#include "Lib.h"
#include "Plot2D.h"

int setMode(CDC& dc, CRect& rectWindow, CRectD& rectWorld) //SetMyMode
{
	int dsx = rectWorld._right - rectWorld._left;
	int dsy = rectWorld._top - rectWorld._bottom;
	int xsl = rectWorld._left;
	int ysl = rectWorld._bottom;
	int dwx = rectWindow.right - rectWindow.left;
	int dwy = rectWindow.bottom - rectWindow.top;
	int xwl = rectWindow.left;
	int ywh = rectWindow.bottom;

	int buffer = dc.SetMapMode(MM_ANISOTROPIC);//���������� ������� ��������� ������������ ������������� ��������� ��������� � ����������� ��������������� �����
	//dc.SetWindowExt(dsx, dsy);///
	//dc.SetViewportExt(dwx, -dwy);//������� ������� ��������� 
	//dc.SetWindowOrg(xsl, 1); //������������� ������ ���� ��������� ����������.
	//dc.SetViewportOrg(xwl, ywh);//������������� ������ ������� ��������� ��������� ����������
	return buffer; // ������������� ����� ����������� ���������� ��������� ����������
}

CMatrix getConverter(CRectD& rectWorld, CRect& rectWindow)// - SpaceToWindow
{
	CMatrix m(3, 3);
	double kx = (double)(((double)(rectWindow.right - rectWindow.left)) / ((double)(rectWorld._right - rectWorld._left)));//��������� ��������� �����  �������� ���� � �������
	double ky = (double)(((double)(rectWindow.bottom - rectWindow.top)) / ((double)(rectWorld._bottom - rectWorld._top)));
	m(0, 1) = m(1, 0) = m(2, 0) = m(2, 1) = 0;
	m(2, 2) = 1;
	m(0, 0) = kx;
	m(0, 2) = rectWindow.left - kx * rectWorld._left;
	m(1, 1) = -ky;
	m(1, 2) = rectWindow.bottom + ky * rectWorld._top;
	return m;
}

CPlot2D::CPlot2D()
{
	_converter.resize(3, 3); // ������ �� ������� 3�3
}

//��������� �������
void CPlot2D::setParams(CMatrix& functionArgument, CMatrix& functionValue, CRect& rectWindow){
	int nRowsX = functionArgument.countRows(), nRowsY = functionValue.countRows();
	if (nRowsX != nRowsY)
	{
		MessageBox(NULL, L"�������������� ������������ ������", L"������", MB_ICONERROR);
	}
	_functionArgument.resize(nRowsX); //������ ������ �� � �� ���������� �������
	_functionValue.resize(nRowsY);//������ ������ �� � �� ���������� �������
	_functionArgument = functionArgument;//������ �������� �� � �� ���������� �������
	_functionValue = functionValue;//������ �������� �� � �� ���������� �������

	_rectWorld._top = _functionValue.getMin();//������� ����� ��� ����.
	_rectWorld._bottom = _functionValue.getMax();//y
	_rectWorld._left = _functionArgument.getMin();//x
	_rectWorld._right = _functionArgument.getMax();//x

	_rectWindow.SetRect(rectWindow.left, rectWindow.top, rectWindow.right, rectWindow.bottom);//������������� ���������� ��������������
	_converter = getConverter(_rectWorld, _rectWindow);
}

void CPlot2D::setRectWindow(CRect& rectWindow)//��������� ������� ��� ����������� �������
{
	_rectWindow.SetRect(rectWindow.left, rectWindow.top, rectWindow.right, rectWindow.bottom);
	_converter = getConverter(_rectWorld, _rectWindow);
}

void CPlot2D::setPenLine(CPlotPen& penLine)//���� ��� ��������� �������
{
	_penLine.set(penLine._style, penLine._width, penLine._color);
}

void CPlot2D::setPenAxis(CPlotPen& penAxis)//���� ���� ���������
{
	_penAxis.set(penAxis._style, penAxis._width, penAxis._color);
}

//�������� �� ������� ���� ��������� � ������� ���� �����
void CPlot2D::getCoordsWindow(double xs, double ys, int &xw, int &yw)
{
	CMatrix V(3), W(3); //������ ������ � ��� ���� ����� � � ������� ����
	V(2) = 1;
	V(0) = xs;
	V(1) = ys;
	W = _converter * V;//������������ � ������� ����
	xw = (int)W(0);
	yw = (int)W(1);
}

//������� ������� ������� � ������� ���� �����
void CPlot2D::getRectWorld(CRectD& rectWorld)
{
	rectWorld._bottom = _rectWorld._bottom;
	rectWorld._left = _rectWorld._left;
	rectWorld._right = _rectWorld._right;
	rectWorld._top = _rectWorld._top;
}

void CPlot2D::plot(CDC& dc, bool drawOuterRect, bool drawInnerGrid)//Draw
{
	dc.SetMapMode(//������������� ����� ����������� ��������� ����������. ���������� ������� ���������, ��� �������������� ������ ��������� ������������ �������� � ������������ ����������
		MM_TEXT);//���������� ������� ��������� ������������ ��� ���� ������� ����������
	CMatrix V(3), W(3);
	V(2) = 1;
	if (drawOuterRect)
	{
		dc.Rectangle(_rectWindow);//������ �������������
	}
	if (drawInnerGrid)//������ ������
	{
		CPen pen(_penAxis._style, _penAxis._width, _penAxis._color);//�������� ��������� ����
		CPen* pOldPen = dc.SelectObject(&pen); // �������� ���� � �������� ������
		if (_rectWorld._left * _rectWorld._right < 0)
		{
			V(0) = 0; //�� � 0
			V(1) = _rectWorld._top; //�� � ���������� �������� �������� ��������������
			W = _converter * V; //������� � ������� ���� �����

			V(0) = 0;
			V(1) = _rectWorld._bottom;
			W = _converter * V;

			for (double i = 0; i < (_rectWindow.bottom - _rectWindow.top); i += 10)
			{
				dc.MoveTo(_rectWindow.left, _rectWindow.top + i);//������ �����
				dc.LineTo(_rectWindow.right, _rectWindow.top + i);//������ �����
			}
			for (double i = 0; i < (_rectWindow.right - _rectWindow.left); i += 10)
			{
				dc.MoveTo(_rectWindow.left + i, _rectWindow.top);
				dc.LineTo(_rectWindow.left + i, _rectWindow.bottom);
			}
		}
		if (_rectWorld._top * _rectWorld._bottom < 0)
		{
			V(0) = _rectWorld._left;
			V(1) = 0;
			W = _converter * V;

			V(0) = _rectWorld._right;
			V(1) = 0;
			W = _converter * V;
		}
		dc.SelectObject(pOldPen);
	}

	V(0) = _functionArgument(0);
	V(1) = _functionValue(0);
	W = _converter * V;
	CPen MyPen(_penLine._style, _penLine._width, _penLine._color);//�������� ��������� ����
	CPen * pOldPen = dc.SelectObject(&MyPen);//�������� � �������� ��� ��������� ����

	dc.MoveTo((int)W(0), (int)W(1));//���������� ��������� �����
	for (int i = 1; i < _functionArgument.countRows(); i++)
	{
		V(0) = _functionArgument(i);
		V(1) = _functionValue(i);
		W = _converter * V;
		dc.LineTo((int)W(0), (int)W(1));//����� �����
	}
	dc.SelectObject(pOldPen);//���������� �������� ���������

}