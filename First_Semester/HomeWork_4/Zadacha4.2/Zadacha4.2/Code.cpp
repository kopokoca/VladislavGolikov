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
	ifstream text("Text.txt");  /* Открываем файл */

	if (!text.is_open())  /* Проверяем открылся ли файл */
	{
		cout << "Файл не может быть открыт!\n";
		return 0;
	}

	cout << "Длина массива из файла: ";  /* Считываем длину массива из файла */
	text >> line;
	cout << line << endl;
	int quantity = 0;
	quantity = line;

	if (quantity < 1)  /* Проверка правильного ввода данных */
	{
		cout << "Ошибка! Длина массива должна быть положителньным числом!\n";
		return 0;
	}
	int *array = new int[quantity];
	cout << "Заданный массив из файла: ";

	for (int i = 0; i < quantity; ++i)  /* Читаем массив из файла */
	{
		text >> line;
		cout << line << " ";
		array[i] = line;
	}
	cout << endl;

	quickSort(array, 0, quantity - 1);  /* Отсортируем массив по порядку */

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

	delete array;
	return 0;  /* Программа проверялась на следующих данных:
			   2| 41 3, Все элементы встречаются один раз
			   -2| Ошибка ввода
			   5| 15 -3 0 0 2, Чаще всего в массиве присутствует число 0*/
}
