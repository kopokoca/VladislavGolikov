#include <iostream>
#include <locale.h>
#include <string>

using namespace std;
int main()
{
	setlocale(LC_ALL, "Russian");
	int check = 0;
	cout << "������� ������:\n";
	string s;
	getline(cin, s);
	int i = 0;
	for (i = 0; i < s.length(); ++i)
	{
		if (s[i] == ' ')
		{
			s.erase(i, 1);
			--i;
		}
	}
	string s1 = s;
	int count = 0;
	for (i = 0; i < s.length() / 2; ++i)
	{
		if (s[i] != s[s.length() - 1 - i])
			++count;
	}
	if (count == 0)
		cout << "������ ������ - ���������\n";
	else
		cout << "������ ������ �� �������� �����������\n";
	return 0;
}