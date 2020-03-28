
// ChildView.cpp: реализация класса CChildView
//

#include "pch.h"
#include "framework.h"
#include "MFCApplication1.h"
#include "ChildView.h"
#include "CMatrix.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CChildView

CChildView::CChildView()
{
	
	A = new CMatrix(3, 3);
	B = new CMatrix(3, 3);
	C1 = new CMatrix(3, 3);
	C2 = new CMatrix(3, 3);
	V1 = new CMatrix(3, 1);
	V2 = new CMatrix(3, 1);
	D = new CMatrix(3, 1);
	q = new CMatrix(1, 1);
	p = new CMatrix(1, 1);
	P1 = new CMatrix(3, 1);

	SetValueMatrixWithIncrement(*A, 0, 0.3);
	SetValueMatrix(*B, 4);
	SetValueMatrix(*V1, 6);
	SetValueMatrix(*V2, 8);
	SetValueMatrix(*P1, 0.2);




	*C1 = *A + *B;
	*C2 = *A * *B;
	*q =   V1->Transp() * *V2;
	*p = V1->Transp() * *A * *V2;
	*D = *A * *V1;
}

CChildView::~CChildView()
{
}


BEGIN_MESSAGE_MAP(CChildView, CWnd) //карта сообщений(сам класс, родительский класс)
	ON_WM_PAINT() 
	ON_COMMAND(ID_MATRIX, PrintMatrixClick) //привязывание id к событиям
	ON_COMMAND(ID_VECTOR, PrintVectorsClick) //
END_MESSAGE_MAP()

void CChildView::PrintMatrixClick()
{
	RedrawWindow();
	
	CDC* dc = GetDC();//необходим для вывода на экран устройства (контекст устройства) 
	dc->TextOut(10, 10, L"A");
	PrintMatrix(*dc, 10, 40, *A);
	
	dc->TextOut(170, 80, L"+");
	dc->TextOut(210, 10, L"B");
	PrintMatrix(*dc, 210, 40, *B);
	
	dc->TextOut(380, 80, L"=");
	dc->TextOut(410, 10, L"C1");
	PrintMatrix(*dc, 410, 40, *C1);

	dc->TextOut(650, 10, L"V1");
	PrintMatrix(*dc, 650, 40, *V1);

	dc->TextOut(750, 10, L"V2");
	PrintMatrix(*dc, 750, 40, *V2);
	
	
	
	dc->TextOut(10, 290, L"A*B=");
	PrintMatrix(*dc, 10, 310, *C2);

	dc->TextOut(300, 290, L"V1(transp)*V2");
	PrintMatrix(*dc, 290, 310, *q);
	
	dc->TextOut(500, 290, L"V1(transp)*A*V2");
	PrintMatrix(*dc, 500, 310, *p);

	dc->TextOut(700, 290, L"A*V1");
	PrintMatrix(*dc, 700, 310, *D);

	

}

void CChildView::PrintVectorsClick()
{
	RedrawWindow();
	
	CDC* dc = GetDC();

	dc->TextOut(10, 10, L"V1");
	PrintMatrix(*dc, 10, 40, *V1);

	dc->TextOut(60, 10, L"V2");
	PrintMatrix(*dc, 60 , 40, *V2);

	dc->TextOut(120, 10, L"Векторное произведение V1,V2=");
	PrintMatrix(*dc, 120, 40, VectorMult(*V1,*V2));
	
	CString  out = L"";
	dc->TextOut(400, 10, L"Скалярное произведение V1,V2=");
	out.Format(L"%.2lf", ScalarMult(*V1,*V2));
	dc->TextOut(400, 40, out);

	dc->TextOut(400, 100, L"|V1|");
	out.Format(L"%.2lf", ModVec(*V1));
	dc->TextOut(400, 120, out);

	dc->TextOut(600, 100, L"cos V1 V2");
	out.Format(L"%.2lf", CosV1V2(*V1, *V2));
	dc->TextOut(600, 120, out);

	dc->TextOut(800, 10, L"Точка P1");
	PrintMatrix(*dc, 800, 40, *P1);

	dc->TextOut(800, 200, L"Точка P1 сферические кординаты:");
	PrintMatrix(*dc, 800, 240, sphericalToCartesian(*P1));
	//L - т.к. метод принимает не char а wchar ( где один символ два байта ) 
	
}


BOOL CChildView::PreCreateWindow(CREATESTRUCT& cs)
{
	if (!CWnd::PreCreateWindow(cs))
		return FALSE;

	cs.dwExStyle |= WS_EX_CLIENTEDGE;
	cs.style &= ~WS_BORDER;
	cs.lpszClass = AfxRegisterWndClass(CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS,
		::LoadCursor(nullptr, IDC_ARROW), reinterpret_cast<HBRUSH>(COLOR_WINDOW + 1), nullptr);

	return TRUE;
}

void CChildView::OnPaint()
{
	CPaintDC dc(this); // контекст устройства для рисования

	// TODO: Добавьте код обработки сообщений

	// Не вызывайте CWnd::OnPaint() для сообщений рисования
}

