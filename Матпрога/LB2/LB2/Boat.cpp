//#include "stdafx.h"
#include "Boat.h"
namespace boatfnc
{
	int calcv(combi::xcombination s, const int v[])  // ���
	{
		int rc = 0;
		for (int i = 0; i < s.m; i++) rc += v[s.ntx(i)];
		return rc;
	};

	int calcc(combi::xcombination s, const int c[]) // ����� 
	{
		int rc = 0;
		for (int i = 0; i < s.m; i++) rc += c[s.ntx(i)];
		return rc;
	};

	void   copycomb(short m, short* r1, const short* r2) // ����������    
	{
		for (int i = 0; i < m; i++)  r1[i] = r2[i];
	};

}
int  boat(
	int V,         // [in]  ������������ ��� �����
	short m,       // [in]  ���������� ���� ��� �����������     
	short n,       // [in]  ����� �����������  
	const int v[], // [in]  ��� ������� ����������  
	const int c[], // [in]  ����� �� ��������� ������� ����������     
	short r[]      // [out] ���������: ������� ��������� �����������  
	)
{
	combi::xcombination xc(n, m);
	int rc = 0, i = xc.getfirst(), cc = 0;
	while (i > 0)
	{
		if (boatfnc::calcv(xc, v) <= V)
			if ((cc = boatfnc::calcc(xc, c)) > rc)
			{
				rc = cc; boatfnc::copycomb(m, r, xc.sset);
			}
		i = xc.getnext();
	};
	return rc;

};
namespace boatfnc
{
	bool compv(combi::accomodation s, const int ming[],
		const int maxg[], const int v[])
	{
		int i = 0;
		while (i < s.m && v[s.ntx(i)] <= maxg[i] && v[s.ntx(i)] >= ming[i])i++;
		return (i == s.m);
	};
	int calcc(combi::accomodation s, const int c[])
	{
		int rc = 0;
		for (int i = 0; i < s.m; i++) rc += c[s.ntx(i)];
		return rc;
	};
	/*void copycomb(short m, short* r1, const short* r2)
	{
		for (int i = 0; i < m; i++)  r1[i] = r2[i];
	};*/
}
int boat_�(      // ������� ���������� ����� �� ��������� �����������
	short m,      // [in] ���������� ���� ��� �����������
	int minv[],   // [in] ����������� ��� ���������� �� ������  ����� 
	int maxv[],   // [in] ������������ ��� ����������� ������ ����� 
	short n,      // [in] ����� �����������  
	const int v[],// [in] ��� ������� ����������  
	const int c[],// [in] ����� �� ��������� ������� ����������   
	short r[]     // [out] ������ ��������� �����������  
	)
{
	combi::accomodation s(n, m);
	int rc = 0, i = s.getfirst(), cc = 0;
	while (i > 0)
	{
		if (boatfnc::compv(s, minv, maxv, v))
			if ((cc = boatfnc::calcc(s, c)) > rc)
				rc = cc; boatfnc::copycomb(m, r, s.sset);
		i = s.getnext();
	};
	return rc;
}