
// ChildView.h: интерфейс класса CChildView
//


#pragma once
#include "CMatrix.h"


// Окно CChildView

class CChildView : public CWnd
{
// Создание
public:
	CChildView();
	afx_msg void PrintMatrixClick(); //
	afx_msg void PrintVectorsClick(); //прототипы методов, которые будут вызываться
// Атрибуты
public:

// Операции
public:

// Переопределение
	protected:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);

// Реализация
public:
	virtual ~CChildView();

	// Созданные функции схемы сообщений
protected:
	afx_msg void OnPaint();
	DECLARE_MESSAGE_MAP()
private:
	CMatrix* A;
	CMatrix* B;
	CMatrix* C2;
	CMatrix* C1;
	CMatrix* D;
	CMatrix* V1;
	CMatrix* V2;
	CMatrix* q;
	CMatrix* p;
	CMatrix* P1;
};

