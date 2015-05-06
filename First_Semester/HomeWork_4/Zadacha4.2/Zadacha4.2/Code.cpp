#include <iostream>
#include <fstream>
#include <locale.h>
#include <cstdlib>
#include <string>
#include "qSort.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	int i = 0;
	int j = 0;
	int pivot = 0;

	int line = 0;
	ifstream text("Text.txt");  /* ��������� ���� */

	if (!text.is_open())  /* ��������� �������� �� ���� */
	{
		cout << "���� �� ����� ���� ������!\n";
		return 0;
	}

	cout << "����� ������� �� �����: ";  /* ��������� ����� ������� �� ����� */
	text >> line;
	cout << line << endl;
	int quantity = 0;
	quantity = line;

	if (quantity < 1)  /* �������� ����������� ����� ������ */
	{
		cout << "������! ����� ������� ������ ���� �������������� ������!\n";
		return 0;
	}
	int *array = new int[quantity];
	cout << "�������� ������ �� �����: ";

	for (int i = 0; i < quantity; ++i)  /* ������ ������ �� ����� */
	{
		text >> line;
		cout << line << " ";
		array[i] = line;
	}
	cout << endl;

	quickSort(array, 0, quantity - 1);  /* ����������� ������ �� ������� */

	int maxCount = 0;
	int maxIndex = 0;
	int count = 0;

	for (int i = 1; i < quantity; ++i)  /* ������� ������������� ������ �������� � ���������� ���-�� ������ ������ ��������� */
	{
		if (array[i - 1] == array[i])
			++count;
		if (count > maxCount)
		{
			maxCount = count;
			maxIndex = i;
		}
	}

	if (maxCount == 0)
		cout << "��� �������� ����������� ������ ���� ���" << endl;
	else
		cout << "���� ����� � ������� ����������� ����� " << array[maxIndex] << endl;

	delete array;
	return 0;  /* ��������� ����������� �� ��������� ������:
			   2| 41 3, ��� �������� ����������� ���� ���
			   -2| ������ �����
			   5| 15 -3 0 0 2, ���� ����� � ������� ������������ ����� 0*/
}
