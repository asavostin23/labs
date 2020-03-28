#include "Auxil.cpp"                            // вспомогательные функции 
#include <iostream>
#include <ctime>
#include <locale>

#define  CYCLE  1000000                       // количество циклов  

int main(int argc, char* argv[])
{

	double  av1 = 0, av2 = 0;
	clock_t  t1 = 0, t2 = 0;

	setlocale(LC_ALL, "rus");

	auxil::start();                          // старт генерации 

	for (int iteration = 1; iteration <= 10; iteration++)
	{
		int cycleNum = CYCLE * iteration;
		t1 = clock();                            // фиксация времени 
		for (int i = 0; i < cycleNum; i++)
		{
			av1 += (double)auxil::iget(-100, 100); // сумма случайных чисел 
			av2 += auxil::dget(-100, 100);         // сумма случайных чисел 
		}
		t2 = clock();                            // фиксация времени 


		std::cout << std::endl << "количество циклов:         " << cycleNum / 1000000 << "M";
		std::cout << std::endl << "среднее значение (int):    " << av1 / cycleNum;
		std::cout << std::endl << "среднее значение (double): " << av2 / cycleNum;
		std::cout << std::endl << "продолжительность (у.е):   " << (t2 - t1);
		std::cout << std::endl << "                  (сек):   "
			<< ((double)(t2 - t1)) / ((double)CLOCKS_PER_SEC);
		std::cout << std::endl;
	}


	system("pause");
	return 0;
}
