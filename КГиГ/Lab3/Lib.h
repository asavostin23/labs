#pragma once

struct CRectD
{
	double _left; //����� ����� ������
	double _top; // ������� ����� ������
	double _right; // ������ ����� ������
	double _bottom; //������ ����� ������
	CRectD(); //��������� � ������� �������
	CRectD(double, double, double, double); //��������� � �������� �������
	void SetRectD(double, double, double, double);
};