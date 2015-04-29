#include <iostream>
#include <locale.h>
#include <cstdlib>

using namespace std;
int main()
{
	setlocale(LC_ALL, "Russian");
	int count = 0;
	int num = 0;
	int beforeNum = 2;
	cout << "Введите число:\n";
	cin >> num;
	if (num <= 1){
		cout << "Таких чисел нет";
	} else
	{
		while (beforeNum <= num)
		{
			for (int i = 2; i < beforeNum; i++)
			{
				if (beforeNum % i == 0) {
					count++;
				}
			}
			if (count == 0) {
				cout << beforeNum << ' ';
			}
			count = 0;
			beforeNum++;
		}
	}
	return 0;
}