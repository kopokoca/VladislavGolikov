#include <iostream>
#include <locale.h>
#include <cstdlib>
#include <string>

using namespace std;

int check(int num)  /* Проверка ввода */
{
	if (num < 0 || num > 127)
	{
		cout << "Ошибка! Неверный ввод. Число должно быть положительным и не более 127!\n";
		exit(0);
	}
	return 0;
}

int from10to2(int num, int array[], int n)  /* Перевод числа из десятичного в двоичное, которое будет хранится в массиве в перевернутом виде */
{
	int power = 1;
	int count = 0;

	while (power <= num)  /* В count окажется кол-во ячеек в массиве, которое необходимо для содержания двоичного числа */
	{
		power = power * 2;
		++count;
	}

	for (int i = 0; i < count; ++i)  /* Заносим в массив остатки числа от деления на 2, тем самы переводя его в двоичную систему */
	{
		array[i] = num % 2;
		num = num / 2;
	}

	for (int i = n - 1; i > -1; --i)   /* Выводим массив задом наперед, так как в нем хранится перевернутое число */
	{
		cout << array[i];
	}
	cout << endl;

	return 0;
}

int from2to10(int array[], int power)  /* Двоичное число из массива переводится в десятичное и выводится */
{
	int pow = 1;
	int answer = 0;

	for (int i = 0; i < power; ++i)  /* Из массива достаются единицы и переводятся в десятичный вид, их сумма - искомое число */
	{
		answer = answer + pow * array[i];
		pow = pow * 2;
	}

	cout << answer << endl;
	return 0;
}

int summare(int first2[], int second2[], int n)  /* Алгоритм складывания столбиком в лоб, рассматриваются 
													все варианты. Можно и быстрее, но не придумал как. */
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

	cout << "Введите первое число, не более 127, целое и положительное: ";  /* Ввод первого числа в десятичой системе */
	int first10;
	cin >> first10;
	check(first10);

	cout << "Введите второе число, не более 127, целое и положительное: ";  /* Ввод второго числа в десятичой системе */
	int second10;
	cin >> second10;
	check(second10);

	const int n = 9;
	int *first2 = new int[n];
	int *second2 = new int[n];
	for (int i = 0; i < n; ++i)  /* Массивы не булевые, поэтому их обнуляем */
	{
		first2[i] = 0;
		second2[i] = 0;
	}

	cout << "Первое число в двоичной системе: ";  /* Вывод первого десятичного числа в двоичной системе */
	from10to2(first10, first2, n); 
	
	cout << "Второе число в двоичной системе: ";  /* Вывод второго числа в двоичной системе */
	from10to2(second10, second2, n);

	cout << "Сумма чисел в двоичном виде: "; /* Вывод суммы двух чисел в двоичной системе */
	summare(first2, second2, n);
	cout << endl;

	cout << "Сумма в десятичном виде: "; /* Вывод суммы в десятичной системе */
	from2to10(first2, n);

	return 0;
}						/* Программа проверялась на следующих данных:
					 2, -2| Ошибка ввода
					   129| Ошибка ввода
					   3,4| 00000011, 00000100, 00000111, 7 */