#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int x = 0;
	/*����������� ���������: x*x*x*x + x*x*x + x*x + x+ 1 (6 ���������)*/
	cout << "������� x:\n";
	cin >> x;
	int sqrX = 0;
	sqrX = x * x;
	x = sqrX * sqrX + sqrX * x + sqrX + x + 1;
	/* a*a + a*x + a + x + 1 (2 ���������)*/
	cout << "�����: " << x << endl;
	return 0;
}
	
	