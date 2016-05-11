#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>

using namespace std;

int main(int argc, char *argv[])
{
    if (argc != 2) {
        cout << "Give me one file to read!" << endl;
    } else {
        ifstream in (argv[1]);

        float sum = 0.0f;
        string line;
        while(getline(in, line)) {
            sum += atof(line.c_str());            
        }

        cout << "Sum: " << sum << endl;
    }
}

