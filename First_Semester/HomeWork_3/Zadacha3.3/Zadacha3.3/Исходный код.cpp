#include <iostream>
#include <locale.h>
#include <cstdlib>

using namespace std;

void quickSort(int arrayA[], int left, int right)
{
	int i = left;
	int j = right;
	int pivot = arrayA[(i + j) / 2];
	while (i < j)
	{
		while (arrayA[i] < pivot)
			++i;
		while (arrayA[j] > pivot)
			--j;
		if (i <= j)
		{
			swap(arrayA[i], arrayA[j]);
			++i;
			--j;
		}
	}
	if (i < right)
		quickSort(arrayA, i, right);

	if (left < j)
		quickSort(arrayA, left, j);
}

void search(int array[], int quantity)
{
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
}

int main()
{
	setlocale(LC_ALL, "Russian");
	int quantity = 0;
	cout << "������� ����� �������: ";
	cin >> quantity;

	if (quantity < 1)  /* �������� ����������� ����� ������ */
	{
		cout << "������! ����� ������� ������ ���� �������������� ������!\n";
		return 0;
	}
	int *array = new int[quantity];
	cout << "�������� ������: ";

	for (int i = 0; i < quantity; ++i)  /* ���������� ������ */
	{
		array[i] = rand() % 222;
		cout << array[i] << " ";
	}
	cout << endl;

	quickSort(array, 0, quantity - 1);  /* ����������� ������ �� ������� */
	search(array, quantity);
	delete array;

	return 0;  /* ��������� ����������� �� ��������� ������:
				  1| 41, ��� �������� ����������� ���� ���
				 -2| ������ �����
				  3| 41 41 118, ���� ����� � ������� ������������ ����� 41*/
}
