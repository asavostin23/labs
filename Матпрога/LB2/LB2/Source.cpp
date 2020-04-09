//#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <time.h>
#include "Combi.h"
#include "Boat.h"
#include "Knapsack.h"
#include "Salesman.h"
#include "Auxil.h"

//#define NN 25
//#define MM 5
#define SPACE(n) std::setw(n)<<" "

void task5()
{
	int V = 1500;
	int NN = 25;
	int MM = 5;

	int* v = new int[NN];

	auxil::start();
	for (int i = 0; i < NN; i++)
		v[i] = auxil::iget(100, 900);

	int* c = new int[NN];

	for (int i = 0; i < NN; i++)
		c[i] = auxil::iget(10, 150);

	short* r = new short[MM];
	int cc = boat(
		V,   // [in]  максимальный вес груза
		MM,  // [in]  количество мест для контейнеров
		NN,  // [in]  всего контейнеров
		v,   // [in]  вес каждого контейнера
		c,   // [in]  доход от перевозки каждого контейнера
		r    // [out] результат: индексы выбранных контейнеров
		);
	std::cout << std::endl << "- Задача о размещении контейнеров на судне";
	std::cout << std::endl << "- общее количество контейнеров    : " << NN;
	std::cout << std::endl << "- количество мест для контейнеров : " << MM;
	std::cout << std::endl << "- ограничение по суммарному весу  : " << V;
	std::cout << std::endl << "- вес контейнеров: ";
	for (int i = 0; i < NN; i++)
		std::cout << std::endl << std::setw(3) << v[i];
	std::cout << std::endl << "- доход от перевозки: ";
	for (int i = 0; i < NN; i++)
		std::cout << std::endl << std::setw(3) << c[i];
	std::cout << std::endl << "- выбраны контейнеры (0,1,...,m-1): ";
	for (int i = 0; i < MM; i++)
		std::cout << r[i] << " ";
	std::cout << std::endl << "- доход от перевозки              : " << cc;
	std::cout << std::endl << "- общий вес выбранных контейнеров : ";
	int s = 0;
	for (int i = 0; i < MM; i++)
		s += v[r[i]]; std::cout << s;
	std::cout << std::endl << std::endl;
}

void task6()
{
	int NN = 35;//25-35
	int* v = new int[NN + 1], * c = new int[NN + 1], * minv = new int[NN + 1], * maxv = new int[NN + 1];
	short* r = new short[NN];
	auxil::start();
	for (int i = 0; i <= NN; i++)
	{
		v[i] = auxil::iget(100, 900);
		c[i] = auxil::iget(10, 150);
		minv[i] = auxil::iget(50, 300);
		maxv[i] = auxil::iget(250, 750);
	}
	std::cout << std::endl << "-- Задача о размещении контейнеров -- ";
	std::cout << std::endl << "-- всего контейнеров: " << NN;
	std::cout << std::endl << "-- количество ------ продолжительность -- ";
	std::cout << std::endl << "  мест     вычисления  ";
	clock_t t1, t2;
	for (int i = 25; i <= NN; i++)
	{
		t1 = clock();
		boat_с(6, minv, maxv, i, v, c, r);
		t2 = clock();
		std::cout << std::endl << SPACE(7) << std::setw(2) << i
			<< SPACE(15) << std::setw(6) << (t2 - t1);
	}
	std::cout << std::endl;
}

void test()
{
	char  AA[][2] = { "A", "B", "C", "D", "E" };
	std::cout << std::endl << " --- Генератор сочетаний ---";
	std::cout << std::endl << "Исходное множество: ";
	std::cout << "{ ";
	for (int i = 0; i < sizeof(AA) / 2; i++)

		std::cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
	std::cout << "}";
	std::cout << std::endl << "Генерация сочетаний ";
	combi::xcombination xc(sizeof(AA) / 2, 3);
	std::cout << "из " << xc.n << " по " << xc.m;
	int  n = xc.getfirst();
	while (n >= 0)
	{

		std::cout << std::endl << xc.nc << ": { ";

		for (int i = 0; i < n; i++)


			std::cout << AA[xc.ntx(i)] << ((i < n - 1) ? ", " : " ");

		std::cout << "}";

		n = xc.getnext();
	};
	std::cout << std::endl << "всего: " << xc.count() << std::endl;

}

int main(int argc, char* argv[])
{
	setlocale(LC_ALL, "rus");

	//task5();
	task6();

	system("pause");
	return 0;
}