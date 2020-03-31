// ChildView.h : ��������� ������ CChildView

#pragma once

#include "CMatrix.h"
#include "Lib.h"
#include "Plot2D.h"

// ���� CChildView

class CChildView : public CWnd
{
	// ��������
public:
	CChildView();

	// ��������
public:
	CPlot2D plot1;
	CPlot2D plot2;
	CPlot2D plot3;
	CPlot2D plot4;
	int graphType;

	// ��������
public:

	// ���������������
protected:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);

	// ����������
public:
	virtual ~CChildView();

	// ��������� ������� ����� ���������
protected:
	afx_msg void OnPaint();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnPlotF1();
	afx_msg void OnPlotF2();
	afx_msg void OnPlotF3();
	afx_msg void OnPlotF4();
	afx_msg void OnPlotAll();
	afx_msg void OnAll();
	afx_msg void OnF1();
	afx_msg void OnF2();
	afx_msg void OnF3();
	afx_msg void OnF4();
};