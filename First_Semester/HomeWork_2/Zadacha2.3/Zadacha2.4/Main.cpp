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
	cout << "Введите кол-во элементов: ";
	cin >> quantity;
	if (quantity <= 0)  /* Проверка положительности числа */
	{
		cout << "Ошибка! Введите положительное число!";
		return 0;
	}
	int arrayA[dimension];
	int arrayB[dimension];
	cout << "Введите неотрицательные элементы массива, не большие тысячи:\n";
	for (int n = 0; n < quantity; ++n)  /* Одинаковое заполнение двух массивов */
	{
		cin >> arrayA[n];
		arrayB[n] = arrayA[n];
		if (arrayA[n] > dimension)  /* Проверяем не больше ли тысячи числа */
		{
			cout << "Ошибка! Число не должно быть больше тысячи!\n";
			return 0;
		}
		if (arrayA[n] < 0)  /* Проверяем положительность числа */
		{
			cout << "Ошибка! Число должно быть неотрицательным!\n";
			return 0;
		}
	}
	bubble(quantity, arrayA);
	cout << "Сортировка пузырьком: ";
	for (int i = 0; i < quantity; ++i)  /* Выводим массив, отсортированный пузырьком */
	{
		cout << arrayA[i] << " ";
	}
	cout << "\n";
	counting(quantity, arrayB);
	cout << "Сортировка подсчетом: ";
	for (int i = 0; i < quantity; ++i)  /* Выводим массив, отсортированный подсчетом */
	{
		cout << arrayB[i] << " ";
	}	
	return 0; /* Программа проверялась на следующих данных (формат ввод|вывод): 
			  2,4 0|0 4, 0 4;
			  3, 777 7 77|7 77 777, 7 77 777;
			  -4, ...| Ошибка ввода кол-ва элементов в массиве; 
			  2,-1...| Ошибка ввода массива; 
			  3,1100...| Ошибка переполнения */
}