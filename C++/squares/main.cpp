#include <cstdlib>
#include <iostream>
#include <string>

using namespace std;

int main(int argc, char *argv[])
{
	if (argc != 2) {
		cerr << "Please set the max!" << endl;
	} else {
		int max = atoi(argv[1]);
		
		for (int i = 0; i <= max; i++) {
			cout << i << " * " << i << " = " << i * i << endl;
		}
	}
}

