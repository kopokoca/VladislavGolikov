#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
	int a, b;
	cin >> a;
	cin >> b;
	a = a + b;
	b = a - b;
	a = a - b;
	cout << a <<" "<< b;
	return 0;
}