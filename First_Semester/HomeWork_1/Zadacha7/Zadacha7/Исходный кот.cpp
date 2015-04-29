#include <iostream>
#include <locale.h>
#include <string>

using namespace std;
int main()
{
	setlocale(LC_ALL, "Russian");
	cout << "Введите строку:\n";
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
			cout << "Порядок скобок нарушен!";
			return 0;
		}
	}
	if (balance == 0)
		cout << "Все скобки расставлены верно.";
	else
		cout << "Ошибка! Проверьте кол-во закрытых и открытых скобок.";
	return 0;
}