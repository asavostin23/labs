#include "stdafx.h"
#include "Lib.h"


//��������� � ������� �������
CRectD::CRectD()
{
	_left = _top = _right = _bottom = 0;
}

//������ �������
CRectD::CRectD(double left, double top, double right, double bottom)
{
	_left = left;
	_top = top;
	_right = right;
	_bottom = bottom;
}

//������ �������
void CRectD::SetRectD(double left, double top, double right, double bottom)
{
	_left = left;
	_top = top;
	_right = right;
	_bottom = bottom;
}