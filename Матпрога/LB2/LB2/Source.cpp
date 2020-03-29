//#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <time.h>
#include "Combi.h"
#include "Boat.h"
#include "Knapsack.h"
#include "Salesman.h"
#include "Auxil.h"
//#define NN (sizeof(v)/sizeof(int))
#define NN 25
#define MM 5
#define SPACE(n) std::setw(n)<<" "

int main(int argc, char* argv[])
{
	setlocale(LC_ALL, "rus");
	int V = 1500;
	int v[NN];
	//{ 100,  200,   300,  400,  500,  150 },
	auxil::start();
	for (int i = 0; i < NN; i++)
		v[i] = auxil::iget(100, 900);
	int c[NN];
	// = { 10,   15,    20,   25,   30,  25 };
	for (int i = 0; i < NN; i++)
		c[i] = auxil::iget(10, 150);
	short  r[MM];
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
		std::cout << std::endl<< std::setw(3) << c[i];
	std::cout << std::endl << "- выбраны контейнеры (0,1,...,m-1): ";
	for (int i = 0; i < MM; i++)
		std::cout << r[i] << " ";
	std::cout << std::endl << "- доход от перевозки              : " << cc;
	std::cout << std::endl << "- общий вес выбранных контейнеров : ";
	int s = 0;
	for (int i = 0; i < MM; i++)
		s += v[r[i]]; std::cout << s;
	std::cout << std::endl << std::endl;
	system("pause");
	return 0;
}