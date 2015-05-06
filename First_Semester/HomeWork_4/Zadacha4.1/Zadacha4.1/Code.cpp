#include <iostream>
#include <locale.h>
#include <cstdlib>
#include <string>

using namespace std;

int check(int num)  /* �������� ����� */
{
	if (num < 0 || num > 127)
	{
		cout << "������! �������� ����. ����� ������ ���� ������������� � �� ����� 127!\n";
		exit(0);
	}
	return 0;
}

int from10to2(int num, int array[], int n)  /* ������� ����� �� ����������� � ��������, ������� ����� �������� � ������� � ������������ ���� */
{
	int power = 1;
	int count = 0;

	while (power <= num)  /* � count �������� ���-�� ����� � �������, ������� ���������� ��� ���������� ��������� ����� */
	{
		power = power * 2;
		++count;
	}

	for (int i = 0; i < count; ++i)  /* ������� � ������ ������� ����� �� ������� �� 2, ��� ���� �������� ��� � �������� ������� */
	{
		array[i] = num % 2;
		num = num / 2;
	}

	for (int i = n - 1; i > -1; --i)   /* ������� ������ ����� �������, ��� ��� � ��� �������� ������������ ����� */
	{
		cout << array[i];
	}
	cout << endl;

	return 0;
}

int from2to10(int array[], int power)  /* �������� ����� �� ������� ����������� � ���������� � ��������� */
{
	int pow = 1;
	int answer = 0;

	for (int i = 0; i < power; ++i)  /* �� ������� ��������� ������� � ����������� � ���������� ���, �� ����� - ������� ����� */
	{
		answer = answer + pow * array[i];
		pow = pow * 2;
	}

	cout << answer << endl;
	return 0;
}

int summare(int first2[], int second2[], int n)  /* �������� ����������� ��������� � ���, ��������������� 
													��� ��������. ����� � �������, �� �� �������� ���. */
{
	int crossing = 0;
	for (int i = 0; i < n; ++i)
	{
		if (first2[i] + second2[i] == 0)
		{
			first2[i] = crossing;
			crossing = 0;
		}
		else
			if (first2[i] + second2[i] == 2)
			{
				first2[i] = crossing;
				crossing = 1;
			}
			else
				if (crossing == 1)
				{
					first2[i] = 0;
					crossing = 1;
				}
				else
				{
					first2[i] = 1;
					crossing = 0;
				}
	}

	for (int i = n - 1; i >= 0; --i)
	{
		cout << first2[i];
	}

	return 0;
}

int main()
{
	setlocale(LC_ALL, "Russian");

	cout << "������� ������ �����, �� ����� 127, ����� � �������������: ";  /* ���� ������� ����� � ��������� ������� */
	int first10;
	cin >> first10;
	check(first10);

	cout << "������� ������ �����, �� ����� 127, ����� � �������������: ";  /* ���� ������� ����� � ��������� ������� */
	int second10;
	cin >> second10;
	check(second10);

	const int n = 9;
	int *first2 = new int[n];
	int *second2 = new int[n];
	for (int i = 0; i < n; ++i)  /* ������� �� �������, ������� �� �������� */
	{
		first2[i] = 0;
		second2[i] = 0;
	}

	cout << "������ ����� � �������� �������: ";  /* ����� ������� ����������� ����� � �������� ������� */
	from10to2(first10, first2, n); 
	
	cout << "������ ����� � �������� �������: ";  /* ����� ������� ����� � �������� ������� */
	from10to2(second10, second2, n);

	cout << "����� ����� � �������� ����: "; /* ����� ����� ���� ����� � �������� ������� */
	summare(first2, second2, n);
	cout << endl;

	cout << "����� � ���������� ����: "; /* ����� ����� � ���������� ������� */
	from2to10(first2, n);

	return 0;
}						/* ��������� ����������� �� ��������� ������:
					 2, -2| ������ �����
					   129| ������ �����
					   3,4| 00000011, 00000100, 00000111, 7 */