#include <iostream>
#include <cstdlib>

using namespace std;

int main(int argc, char *argv[])
{
	if (argc != 5) {
		cerr << "Please set the coefficients and the constant terms!" << endl;
		return 1;
	}
	
	float co_ex0, co_ex1, cons0, cons1;
	co_ex0 = atof(argv[1]);
	cons0 = atof(argv[2]);
	co_ex1 = atof(argv[3]);
	cons1 = atof(argv[4]);

	cout << "(";
	
	if (co_ex0 == -1)
		cout << "-";
	else if (co_ex0 != 1)
		cout << co_ex0 << " * ";
	cout << "x";
	
	if (cons0 > 0)
		cout << " + " << cons0;
	else
		cout << " - " << -1 * cons0;

	cout << ") * (";
	
	if (co_ex1 == -1)
		cout << "-";
	else if (co_ex1 != 1)
		cout << co_ex1 << " * ";
	cout << "x ";

	if (cons1 > 0)
		cout << "+ " << cons1;
	else
		cout << "- " << -1 * cons1;
	
	cout << ") = ";
	
	float a, b, c;
	a = co_ex0 * co_ex1;
	b = co_ex0 * cons1 + co_ex1 * cons0;
	c = cons0 * cons1;
	
	if (a == -1)
		cout << "-";
	else if (a != 1)
		cout << a << " * ";
	cout << "x ** 2 ";
	
	if (b > 0) {
		cout << "+ ";
		if (b != 1)
			cout << b << " * ";
	} else {
		cout << "- ";
		if (c!= -1)
			cout << -1 * b << " * ";
	}	
	cout << "x ";

	if (c > 0)
		cout << "+ " << c;
	else
		cout << "- " << -1 * c;

	cout << endl;
}

