//#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <time.h>
#include "Combi.h"
#include "Boat.h"
#include "Knapsack.h"
#include "Salesman.h"
#define NN 4
#define MM 6
#define SPACE(n) std::setw(n)<<" "


int main(int argc, char* argv[])
{
    setlocale(LC_ALL, "rus");
    char  AA[][2] = { "A", "B", "C", "D" };
    std::cout << std::endl << " - ��������� ��������� ���� ����������� -";
    std::cout << std::endl << "�������� ���������: ";
    std::cout << "{ ";
    for (int i = 0; i < sizeof(AA) / 2; i++)
        std::cout << AA[i] << ((i < sizeof(AA) / 2 - 1) ? ", " : " ");
    std::cout << "}";
    std::cout << std::endl << "��������� ���� �����������  ";
    combi::subset s1(sizeof(AA) / 2);         // �������� ����������   
    int  n = s1.getfirst();                // ������ (������) ������������    
    while (n >= 0)                          // ���� ���� ������������ 
    {
        std::cout << std::endl << "{ ";
        for (int i = 0; i < n; i++)
            std::cout << AA[s1.ntx(i)] << ((i < n - 1) ? ", " : " ");
        std::cout << "}";
        n = s1.getnext();                   // c�������� ������������ 
    };
    std::cout << std::endl << "�����: " << s1.count() << std::endl;
    system("pause");
    return 0;
}
