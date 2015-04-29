#include <iostream>
#include <locale.h>
#include <cstdlib>

using namespace std;
int main()
{
	setlocale(LC_ALL, "Russian");
	int dividend = 0;
	int divisor = 0;
	int count = 0; 
	int quot = 0;
	cout << "Введите делимое и делитель:\n";
	cin >> dividend;
	cin >> divisor;
	if ((dividend * divisor) >= 0)
	{
		while (abs(quot) <= abs(dividend))
		{
			count++;
			quot = count * divisor;
		}
	}
	else
	{
		while (abs(dividend) >= abs(quot))
		{
			count--;
			quot = divisor * count;
		}
		count = count + 2;
	}
	count = count - 1;
	cout << "Неполное частное: " << count;
	return 0;
}