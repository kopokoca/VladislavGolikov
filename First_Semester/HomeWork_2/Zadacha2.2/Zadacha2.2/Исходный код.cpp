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
	cout << "������� �����, ������� �� ������ �� ������ 9:\n";
	cin >> num;
	cout << "������� ��������������� ������� �� ������ 9:\n";
	cin >> k;
	if ((abs(num) + abs(k)) > 18)  /* �������� ������� ����� ������*/
	{  
		cout << "������! ����� ������� ������!";
		return 0;
	}
	if (k < 0)
	{
		cout << "������! ������� ��������������� �������!\n";
		return 0;
	}
	cout << "����� �������� � ���:\n" << slowVersion(k, num) << "\n����� ������� ����������� � �������:\n" << fastVersion(k, num) << "\n";
	return 0;  /* ��������� ����������� �� ��������� ������ (������ ����|�����): 
			   6,6|46656, 46656;
			   -4, 7|-16384, -16384; 
			   2,-1| ������ �����; 
			   11,11| ������ ������������ */
}
