#include <iostream>
#include <cstdlib>

using namespace std;

//	������� ����������
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

// �������� �����
bool search(int array[], int left, int right, int num )
{
	if (num == array[left] || num == array[right])
		return true;

	while (left != right)
	{
		int half = (left + right) / 2;

		if (num > array[half])
		{
			left = half + 1;
		}
		if (num < array[half])
		{
			right = half;
		}
		if (num == array[half])
			return true;
	}
	return false;
}

int main()
{
	setlocale(LC_ALL, "Russian");
	int n = 0;
	cout << "������� ����� �������: ";
	cin >> n;
	if (n < 1)  

/* �������� ����� ����� ������� */
	{
		cout << "������! ����� ������� ������ ���� �������������� ������!\n";
		return 0;
	}

	int k = 0;
	cout << "������� ���-�� �����: ";
	cin >> k;

/* �������� ����� ���-�� ����� */
	if (k < 1)  
	{
		cout << "������! ������ ���� ��� ������� ���� �����!\n";
		return 0;
	}

	int *array = new int[n];
	cout << "�������� ������: ";

/* ���������� ������ */
	for (int i = 0; i < n; ++i)  
	{
		array[i] = rand() % 100;
		cout << array[i] << " ";
	}
	cout << endl;

/* ��������� ������ */
	quickSort(array, 0, n - 1);  

/* k ��� ���������� ������� � ��������� ������� �� �� � �������, ������� ��������� */
	for (int i = 0; i < k; ++i)  
	{
		int num = rand() % 100;
		cout << "����� " << num;
		if (search(array, 0, n, num))
			cout << " ������� � �������" << endl;
		else
			cout << " ����������� � �������" << endl;
	}

	delete array;
	return 0;
}