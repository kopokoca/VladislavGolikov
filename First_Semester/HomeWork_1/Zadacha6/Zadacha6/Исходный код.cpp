#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int array[28];
	for (int i = 0; i <= 27; i++)
	{
		array[i] = 0;
	}
	for (int i = 0; i <= 9; i++)
	{
		for (int j = 0; j <= 9; j++)
		{
			for (int k = 0; k <= 9; k++)
			{
				array[i + j + k]++;
			}
		}
	}
	int count = 0;
	for (int i = 0; i <= 27; i++) 
	{
		count = count + array[i] * array[i];
	}
	cout << "Всего счастливых билетов: " << count << endl;
	return 0;
}