// Gnomons.cpp : Defines the entry point for the application.
//

#include "Gnomons.h"

#include <iostream>
#include <string>
#include <stdexcept>

using std::cout;
using std::cerr;
using std::endl;

using std::string; // Add this after includes to bring 'string' into scope

static void print_gnomon(const int n) {
    for (auto i = 0; i < n; i++) {
        cout << "a";
    }
    cout << endl;

    for (auto i = 0; i < n - 1; i++) {
        for (auto j = 0; j < n - 1; j++) {
            cout << " ";
        }
        cout << "a" << endl;
    }
}

int main(const int argc, char* argv[]) {
    if (argc != 2) {
        cerr << "Please set the max!" << endl;
    }
    else {
        const string input(argv[1]);

        try {
            const auto max = stoi(input);

            if (max < 1) {
                cerr << "Please set an integer greater than 0!" << endl;
            }

            for (auto i = 1; i <= max; i++) {
                cout << i << endl;
				print_gnomon(i);
                cout << endl;
            }
        }
        catch (const std::invalid_argument& ia) {
            cerr << "Unable to parse input - \"" << input << "\"!" << endl;
        }
    }
}

