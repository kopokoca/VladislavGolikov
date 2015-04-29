#include <iostream>
#include <cstring>
#include <memory>

using namespace std;

// Быстрая сортировка
 int qsort(int arrayB[], int first, int last)
{
	int i = first;
	int j = last;
	int x = arrayB[(first + last) / 2];
	while (i <= j)
	{
		while (arrayB[i] < x) i++;
		while (arrayB[j] > x) j--;

		if (i <= j) 
		{
			if (arrayB[i] > arrayB[j]) swap(arrayB[i], arrayB[j]);
			i++;
			j--;
		}
	}

	if (i < last)
		qsort(arrayB, i, last);
	if (first < j)
		qsort(arrayB, j, first);
	return 0;
}

//	Сортировка пузырьком
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
	int quantity = 0;
	cout << "Введите кол-во элементов: ";
	cin >> quantity;

/* Проверка положительности числа */
	if (quantity <= 0)  
	{
		cout << "Ошибка! Введите положительное число!" << endl;
		return 0;
	}

	int arrayA[dimension] = { 0 };
	cout << "Введите неотрицательные элементы массива, не большие тысячи:\n";

/* Одинаковое заполнение двух массивов */
	for (int n = 0; n < quantity; ++n)  
	{
		cin >> arrayA[n];
	}

	if (quantity < 10)
	{
		bubble(quantity, arrayA);
		cout << "Сортировка пузырьком: ";

		/* Выводим массив, отсортированный пузырьком */
		for (int i = 0; i < quantity; ++i)
		{
			cout << arrayA[i] << " ";
		}

		cout << "\n";
	}
	else
	{
		int first = 0;
		int last = quantity - 1;

		qsort(arrayA, first, last);
		cout << "Сортировка подсчетом: ";

		/* Выводим массив, отсортированный подсчетом */
		for (int i = 0; i < quantity; ++i)
		{
			cout << arrayA[i] << " ";
		}
	}
	return 0;
} 