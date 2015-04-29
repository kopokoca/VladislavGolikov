#include <iostream>
#include <locale.h>
#include <stdlib.h>

using namespace std;

int Sort(int arrayA[], int quantity)
{
	int first = arrayA[0];
	int left = 1;
	int right = quantity - 1;
	int exchange = 0;
	while (left < right)  /* left ��������� ���������� �� ������ ������� �������, � right �� ������������� */
	{
		if (arrayA[left] > first)
		{
			exchange = arrayA[left];
			arrayA[left] = arrayA[right];
			arrayA[right] = exchange;
			--right;
		}
		else
		{
			++left;
		}
	}
	if (first > arrayA[left])
	{
		arrayA[0] = arrayA[left];
		arrayA[left] = first;
	}
	return 0;
}

int main()
{
	setlocale(LC_ALL, "Russian");
	int quantity = 0;
	cout << "������� ���-�� ���������: ";
	cin >> quantity;
	if (quantity < 1)  /* �������� ������������ ����� */
	{
		cout << "������! ���-�� ������ ���� �������������!\n";
		return 0;
	}
	int arrayA[1000];
	srand(1000);
	cout << "������: ";
	for (int n = 0; n < quantity; ++n)  /* ���������� ������� */
	{
		arrayA[n] = rand() % 111;
		cout << arrayA[n]<< " ";
	}
	cout << endl;
	if (quantity == 1)  /* ��� ����� �������� � ������� �� � ��������� */
	{
		cout << "����� ������: " << arrayA[0] << endl;
		return 0;
	}
	Sort(arrayA, quantity);
	cout << "�������� ������: ";
	for (int n = 0; n < quantity; ++n)  /* ������� �������� ������ */
		cout << arrayA[n] << " ";
	cout << endl;
	return 0; /* ��������� ����������� �� ��������� ������ (������ ����|�����): 
			  1|85, 85;
			  -4| ������ ����� ���-�� ��������� � �������; 
			  2,|85 7, 7 85; */
}