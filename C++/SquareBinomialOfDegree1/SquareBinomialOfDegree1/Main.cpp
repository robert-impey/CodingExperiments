#include <iostream>
#include <cstdlib>

using namespace std;

void print_squared_binomial(double, double);
void print_expanded_squared_binomial(double, double);

int main(int argc, char *argv[])
{
	if (argc != 3) {
		cerr << "Please set the coefficient of x and the constant term!" << endl;
	} else {
		double co_x, con_term;
		co_x = atof(argv[1]);
		con_term = atof(argv[2]);
		
		if (co_x == 0 || con_term == 0) {
			cerr << "You can work that one out on your own!" << endl;
			return 0;
		}

		print_squared_binomial(co_x, con_term);
		
		cout << " = ";
		
		print_expanded_squared_binomial(co_x, con_term);

		cout << endl;
	}	
}

void print_squared_binomial(double co_x, double con_term)
{
	cout << "(";
		
	if (co_x == -1)
		cout << "-";
	else if (co_x != 1) 
		cout << co_x << " * ";
		
	cout << "x ";
	
	if (con_term > 0)
		cout << "+ " << con_term;
	else
		cout << "- " << -1 * con_term;	

	cout << ") ** 2";
}

void print_expanded_squared_binomial(double co_x, double con_term)
{
	if (co_x * co_x != 1)
		cout << co_x * co_x << " * ";
		
	cout << "x ** 2 ";

	if (con_term == 0.5)
		cout << "+ ";
	else if (con_term == -0.5)
		cout << "- ";
	else {
		if (con_term > 0)
			cout << "+ " << 2 * con_term;
		else 
			cout << "- " << -2 * con_term;

		cout << " * ";
	}
	cout << "x ";

	cout << "+ " << con_term * con_term;
}
