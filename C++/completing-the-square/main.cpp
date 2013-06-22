#include <iostream>
#include <cstdlib>

using namespace std;

int main(int argc, char *argv[])
{
	if (argc != 4) {
		cerr << "Please give me a, b and c!" << endl;
		return 1;
	}
	
	float a, b, c;
	a = atof(argv[1]);
	b = atof(argv[2]);
	c = atof(argv[3]);
	
	cout << a << " * x ** 2 + " << b << " * x + " << c << " = ";
	cout << a << " * (x - " << -1 * (b / (2 * a)) << ") ** 2 + " << c - ((b * b) / (4 * a));
	cout << endl;		
}
