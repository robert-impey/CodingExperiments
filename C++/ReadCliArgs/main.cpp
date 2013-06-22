/* 
 * File:   main.cpp
 * Author: Robert
 *
 * Created on 09 June 2011, 20:14
 */

#include <cstdlib>
#include <iostream>
#include <unistd.h>

#include "main.hpp"

using namespace std;

int main(int argc, char** argv) {
    Args args = process_args(argc, argv);

    cout << "a: " << args.a << "\tb:" << args.b << "\n";

    return 0;
}

Args process_args(int argc, char** argv) {
    int optRtn;
    Args args;

    while ((optRtn = getopt(argc, argv, "A:B:")) != -1) {
        switch (optRtn) {
            case 'A':
                args.a = atoi(optarg);
                break;

            case 'B':
                args.b = atof(optarg);
                break;

            default:
                cerr << endl;
                cerr << "Usage: " << argv[0] << endl
                        << "         [-A (int)an int] \\ " << endl
                        << "         [-B (float)a float] \\ " << endl
                        << endl;
                exit(1);
        }
    }

    return args;
}
