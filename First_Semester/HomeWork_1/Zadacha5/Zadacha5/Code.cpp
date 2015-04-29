#include <iostream>
#include <locale.h>
#include <cstdlib>

using namespace std;

void exchange(int array[], int begin, int end)  /* Переворачивание куска массива задом наперед */
{
	for (int i = begin; i < (end + begin + 1) / 2; i++)
	{
		int temp = array[i];
		array[i] = array[end + begin - i - 1];
		array[end + begin - i - 1] = temp;
	}
}

int main()
{
	setlocale(LC_ALL, "Russian");

	int const m = 3;
	int const n = 5;
	int A[m + n] = { 0 };

	cout << "Введите массив:\n";  /* Ввод массива */
	for (int i = 0; i < (m + n); ++i) 
		cin >> A[i];

	exchange(A, 0, m );
	exchange(A, m, m + n);
	exchange(A, 0, m + n);

	cout << "Новый массив:\n";  /* Вывод массива */
	for (int i = 0; i <= (m + n - 1); i++)
		cout << A[i] << " ";

	return 0;
}