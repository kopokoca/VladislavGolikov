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
	for (int i = 1; i < quantity; ++i)  /* Считаем повторяющиеся подряд элементы и наибольшее кол-во подряд идущих сохраняем */
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
		cout << "Все элементы встречаются только один раз" << endl;
	else
		cout << "Чаще всего в массиве встречается число " << array[maxIndex] << endl;
}

int main()
{
	setlocale(LC_ALL, "Russian");
	int quantity = 0;
	cout << "Введите длину массива: ";
	cin >> quantity;

	if (quantity < 1)  /* Проверка правильного ввода данных */
	{
		cout << "Ошибка! Длина массива должна быть положителньным числом!\n";
		return 0;
	}
	int *array = new int[quantity];
	cout << "Заданный массив: ";

	for (int i = 0; i < quantity; ++i)  /* Генерируем массив */
	{
		array[i] = rand() % 222;
		cout << array[i] << " ";
	}
	cout << endl;

	quickSort(array, 0, quantity - 1);  /* Отсортируем массив по порядку */
	search(array, quantity);
	delete array;

	return 0;  /* Программа проверялась на следующих данных:
				  1| 41, Все элементы встречаются один раз
				 -2| Ошибка ввода
				  3| 41 41 118, Чаще всего в массиве присутствует число 41*/
}
