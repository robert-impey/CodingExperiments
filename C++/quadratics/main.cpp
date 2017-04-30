#include <cstdlib>
#include <cmath>
#include <iostream>
#include <string>

#include "process_args.hpp"

using namespace std;

int main(int argc, char *argv[])
{
    Args args;

    if (process_args(argc, argv, &args)) {
        float a, b, c;
        bool just_discriminant;

        a = args.a;
        b = args.b;
        c = args.c;
        just_discriminant = args.d;

        float discriminant = (b * b) - (4 * a * c);

        if (just_discriminant) {
            cout << "The discriminant is " << discriminant << "." << endl;
        } else {
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
    } else {
        cerr << "You must give me a, b and c!" << endl;
    }
}
