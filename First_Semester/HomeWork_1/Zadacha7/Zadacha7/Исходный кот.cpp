#include <iostream>
#include <locale.h>
#include <string>

using namespace std;
int main()
{
	setlocale(LC_ALL, "Russian");
	cout << "������� ������:\n";
	int balance = 0;
	string s;
	getline(cin, s);
	int l = s.length();
	for (int i = 0; i < l; i++)
	{
		if (s[i] == '(')
			balance++;
		else if (s[i] == ')')
			balance--;
		if (balance < 0)
		{
			cout << "������� ������ �������!";
			return 0;
		}
	}
	if (balance == 0)
		cout << "��� ������ ����������� �����.";
	else
		cout << "������! ��������� ���-�� �������� � �������� ������.";
	return 0;
}