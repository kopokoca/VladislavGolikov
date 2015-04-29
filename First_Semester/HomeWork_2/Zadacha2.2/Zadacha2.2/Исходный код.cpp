#include <iostream>
#include <locale.h>
#include <cstdlib>

using namespace std;

int slowVersion(int n, int num)
{
	int answer = 1;
	for (int i = 0; i < n; ++i)
	{
		answer = answer * num;
	}
	return answer;
}

int fastVersion(int n, int num)
{
	int answer = 1;
	while (n > 0)
	{
		if (n % 2 == 1)
		{
		answer = answer * num;
		}
	num = num * num;
	n = n / 2;
	}
	return answer;
}

int main()
{
	setlocale(LC_ALL, "Russian");
	int num = 0;
	int k = 0;
	cout << "Введите число, которое по модулю не больше 9:\n";
	cin >> num;
	cout << "Введите неотрицательную степень не больше 9:\n";
	cin >> k;
	if ((abs(num) + abs(k)) > 18)  /* Проверка верного ввода данных*/
	{  
		cout << "Ошибка! Число слишком велико!";
		return 0;
	}
	if (k < 0)
	{
		cout << "Ошибка! Введите неотрицательную степень!\n";
		return 0;
	}
	cout << "Ответ решением в лоб:\n" << slowVersion(k, num) << "\nОтвет быстрым возведением в степень:\n" << fastVersion(k, num) << "\n";
	return 0;  /* Программа проверялась на следующих данных (формат ввод|вывод): 
			   6,6|46656, 46656;
			   -4, 7|-16384, -16384; 
			   2,-1| Ошибка ввода; 
			   11,11| Ошибка переполнения */
}
