#include <iostream>

using namespace std;

int counting(int quantity, int A[])
{
	int const dimension = 1000;
	int C[dimension] = { 0 };
	for (int i = 0; i < quantity; ++i)
	{
		++C[A[i]];
	}
	int count = 0;
	for (int j = 0; j < dimension; ++j)
	{
		for (int i = 0; i < C[j]; ++i)
		{
			A[count] = j;
			++count;
		}
	}
	return 0;
}

int bubble(int quantity, int B[])
{
	int exchange = 0;
	for (int i = 0; i < quantity; ++i)
	{
		for (int j = 0; j < quantity - i - 1; ++j)
		{
			if (B[j] > B[j + 1])
			{
				exchange = B[j];
				B[j] = B[j + 1];
				B[j + 1] = exchange;
			}
		}
	}
	return 0;
}
 
int main()
{
	setlocale(LC_ALL, "Russian");
	int const dimension = 1000;
	int quantity = 0;;
	cout << "������� ���-�� ���������: ";
	cin >> quantity;
	if (quantity <= 0)  /* �������� ��������������� ����� */
	{
		cout << "������! ������� ������������� �����!";
		return 0;
	}
	int arrayA[dimension];
	int arrayB[dimension];
	cout << "������� ��������������� �������� �������, �� ������� ������:\n";
	for (int n = 0; n < quantity; ++n)  /* ���������� ���������� ���� �������� */
	{
		cin >> arrayA[n];
		arrayB[n] = arrayA[n];
		if (arrayA[n] > dimension)  /* ��������� �� ������ �� ������ ����� */
		{
			cout << "������! ����� �� ������ ���� ������ ������!\n";
			return 0;
		}
		if (arrayA[n] < 0)  /* ��������� ��������������� ����� */
		{
			cout << "������! ����� ������ ���� ���������������!\n";
			return 0;
		}
	}
	bubble(quantity, arrayA);
	cout << "���������� ���������: ";
	for (int i = 0; i < quantity; ++i)  /* ������� ������, ��������������� ��������� */
	{
		cout << arrayA[i] << " ";
	}
	cout << "\n";
	counting(quantity, arrayB);
	cout << "���������� ���������: ";
	for (int i = 0; i < quantity; ++i)  /* ������� ������, ��������������� ��������� */
	{
		cout << arrayB[i] << " ";
	}	
	return 0; /* ��������� ����������� �� ��������� ������ (������ ����|�����): 
			  2,4 0|0 4, 0 4;
			  3, 777 7 77|7 77 777, 7 77 777;
			  -4, ...| ������ ����� ���-�� ��������� � �������; 
			  2,-1...| ������ ����� �������; 
			  3,1100...| ������ ������������ */
}