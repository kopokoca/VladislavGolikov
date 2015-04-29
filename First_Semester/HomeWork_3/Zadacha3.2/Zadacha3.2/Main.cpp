#include <iostream>
#include <cstdlib>

using namespace std;

//	Быстрая сортировка
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

// Бинарный поиск
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
	cout << "Введите длину массива: ";
	cin >> n;
	if (n < 1)  

/* Проверка ввода длины массива */
	{
		cout << "Ошибка! Длина массива должна быть положителньным числом!\n";
		return 0;
	}

	int k = 0;
	cout << "Введите кол-во чисел: ";
	cin >> k;

/* Проверка ввода кол-ва чисел */
	if (k < 1)  
	{
		cout << "Ошибка! Должно быть как минимум одно число!\n";
		return 0;
	}

	int *array = new int[n];
	cout << "Заданный массив: ";

/* Генерируем массив */
	for (int i = 0; i < n; ++i)  
	{
		array[i] = rand() % 100;
		cout << array[i] << " ";
	}
	cout << endl;

/* Сортируем массив */
	quickSort(array, 0, n - 1);  

/* k раз генерируем элемент и проверяем имеется ли он в массиве, выводим результат */
	for (int i = 0; i < k; ++i)  
	{
		int num = rand() % 100;
		cout << "Число " << num;
		if (search(array, 0, n, num))
			cout << " имеется в массиве" << endl;
		else
			cout << " отсутствует в массиве" << endl;
	}

	delete array;
	return 0;
}