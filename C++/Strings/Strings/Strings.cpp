// Strings.cpp : Defines the entry point for the application.
//

#include "Strings.h"
#include <iostream>
#include <fstream>

using namespace std;

int main(int argc, char* argv[]) {
	if (argc <= 1) {
		cerr << "Tell me what to do." << endl;
		return 1;
	}

	string task(argv[1]);

	if (task == "list") {
		if (argc <= 2) {
			cerr << "Please tell me the file name to list!" << endl;
			return 1;
		}

		string file_name(argv[2]);

		// See https://www.cplusplus.com/forum/general/281709/

		if (ifstream file{ file_name })
		{
			string s;
			while (file >> s)
			{
				cout << s << endl;
			}
		}

		return 0;
	}

	cerr << "Unrecognized task - " << task << endl;
	return 1;
}
