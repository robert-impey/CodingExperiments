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

    cout << "(" << a << " * x ** 2) ";

    if (b >= 0) {
        cout << "+ (" << b;
    } else {
        cout << "- (" << b * -1.0;
    }
    cout <<" * x) ";

    if (c >= 0) { 
        cout << "+ " << c;
    } else {
        cout << "- " << c * -1.0;
    }

    cout << " = ";

    float xSubtractor = -1 * (b / (2 * a));
    cout << a << " * (x";

    if (xSubtractor >= 0.0) {
        cout << " - ";
        cout << xSubtractor;
    } else {
        cout << " + ";
        cout << -1.0 * xSubtractor;
    }

    cout << ") ** 2 "; 

    float remainder = c - ((b * b) / (4 * a));

    if (remainder >= 0) {
        cout << "+ " << remainder;
    } else {

        cout << "- " <<  remainder * -1.0;
    }

    cout << endl;		
}
