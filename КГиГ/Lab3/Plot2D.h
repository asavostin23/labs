#pragma once
#define K_GRAPH_CENTER 2
#define K_GRAPH_1 1.3
int setMode(CDC&, CRect&, CRectD&);

CMatrix getConverter(CRectD&, CRect&);

struct CPlotPen
{
	int _style, _width;
	COLORREF _color;

	CPlotPen()
	{
		_style = PS_SOLID; //�������� ����
		_width = 1;
		_color = RGB(0, 0, 0);
	}
	void set(int style, int width, COLORREF color)
	{
		_style = style;
		_width = width;
		_color = color;
	}
};

class CPlot2D
{
private:
	CMatrix _functionArgument, _functionValue, _converter;// ��������, �������, ������� ��������� ���������
	CRect _rectWindow; //������������� � ����
	CRectD _rectWorld; //������������� � ������� ���� �����
	CPlotPen _penLine, _penAxis;// ����� ��� ����� � ����

public:
	CPlot2D();// ����������� �� ���������
	void setParams(CMatrix&, CMatrix&, CRect&); //��������� �������
	void setRectWindow(CRect&); //��������� ������� ��� ����������� �������
	void setPenLine(CPlotPen&); //���� ��� ��������� �������
	void setPenAxis(CPlotPen&); //���� ���� ���������
	void getCoordsWindow(double, double, int&, int&); //�������� �� ������� ���� ��������� � ������� ���� �����
	void getRectWorld(CRectD&);  //������� ������� ������� � ������� ���� �����
	void plot(CDC&, bool, bool, int); //���������
};
