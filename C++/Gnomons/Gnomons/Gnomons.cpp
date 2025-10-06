// Gnomons.cpp : Defines the entry point for the application.
//

#include "Gnomons.h"

#include <iostream>
#include <string>

using namespace std;

int main(int argc, char* argv[]) {
    if (argc != 2) {
        cerr << "Please set the max!" << endl;
    }
    else {
        string input(argv[1]);

        try {
            auto max = stoi(input);

            if (max < 1) {
                cerr << "Please set an integer greater than 0!" << endl;
            }

            for (auto i = 1; i <= max; i++) {
                cout << i << endl;
            }
        }
        catch (const std::invalid_argument& ia) {
            cerr << "Unable to parse input - \"" << input << "\"!" << endl;
        }
    }
}
