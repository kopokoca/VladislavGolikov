#include <iostream>
#include <locale.h>
#include <cstdlib>

using namespace std;
int main()
{
	setlocale(LC_ALL, "Russian");
	int m = 0;
	int const x = 10;
	int A[x];/*A[x], ��� x - ���-�� ��-�� � �������*/
	cout << "������� ������:\n";
	for (int i = 0; i < x; i++) {
		cin >> A[i];
	}
	for (int i = 0; i < x; i++){
		if (A[i] == 0) {
			m++;
		}
	}
	cout << "����� ������� ���������: " << m;
	return 0;
}