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
	while (left < right)  /* left указывает изначально на второй элемент массива, а right на предпоследний */
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
	cout << "Введите кол-во элементов: ";
	cin >> quantity;
	if (quantity < 1)  /* Проверка корректности ввода */
	{
		cout << "Ошибка! кол-во должно быть положительным!\n";
		return 0;
	}
	int arrayA[1000];
	srand(1000);
	cout << "Массив: ";
	for (int n = 0; n < quantity; ++n)  /* Заполнение массива */
	{
		arrayA[n] = rand() % 111;
		cout << arrayA[n]<< " ";
	}
	cout << endl;
	if (quantity == 1)  /* При одном элементе в массиве он и выведется */
	{
		cout << "Новый массив: " << arrayA[0] << endl;
		return 0;
	}
	Sort(arrayA, quantity);
	cout << "Итоговый массив: ";
	for (int n = 0; n < quantity; ++n)  /* Выводим итоговый массив */
		cout << arrayA[n] << " ";
	cout << endl;
	return 0; /* Программа проверялась на следующих данных (формат ввод|вывод): 
			  1|85, 85;
			  -4| Ошибка ввода кол-ва элементов в массиве; 
			  2,|85 7, 7 85; */
}