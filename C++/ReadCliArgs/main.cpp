/* 
 * File:   main.cpp
 * Author: Robert Impey
 *
 * Created on 09 June 2011, 20:14
 */

#include <iostream>

#include "process_args.hpp"

using namespace std;

int main(int argc, char** argv) {
    Args args;

    if (process_args(argc, argv, &args)) {
        cout << "a: " << args.a << "\tb:" << args.b << "\n";
        return 0;
    } else {
        cerr << endl;
        cerr << "Usage: " << argv[0] << endl
                << "         [-A (int)an int] \\ " << endl
                << "         [-B (float)a float] \\ " << endl
                << endl;
        return 1;
    }
}

