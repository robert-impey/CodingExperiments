#include <cstdlib>
#include <cmath>
#include <iostream>
#include <string>

using namespace std;

int main(int argc, char *argv[])
{
	if (argc != 4) {
		cerr << "You must give me a, b and c!" << endl;
	} else {
		float a, b, c;
		a = atof(argv[1]);
		b = atof(argv[2]);
		c = atof(argv[3]);

		float discriminant = (b * b) - (4 * a * c);
		
		if (discriminant < 0) {
			cout << "The curve does not cross the x-axis!" << endl;
		} else {
			float sqrt_d = sqrt(discriminant);
			float x0, x1;
			x0 = ((-1 * b) + sqrt_d) / (2 * a);
			x1 = ((-1 * b) - sqrt_d) / (2 * a);

			if (x0 == x1) {
				cout << "The curve touches the x axis at " << x0 << "." << endl;
			} else {
				cout << "The curve crosses the x axis at " << x0 << " and " << x1 << "." << endl;
			}
		}
	}
}
