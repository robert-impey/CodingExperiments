// FiveLetters.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <fstream>

using namespace std;

int main(int argc, char* argv[]) 
{
	if (argc <= 1) {
		cerr << "Tell me what to do." << endl;
		return 1;
	}

	string task(argv[1]);

	if (task == "find_5_letter_words") {
		string s;
		while (cin >> s)
		{
			if (s.size() == 5)
				cout << s << endl;
		}

		return 0;
	}

	if (task == "remove_words_with_non_latin") {
		string s;
		while (cin >> s)
		{
			auto all_latin = true;
			for (auto c : s)
			{
				if (!((c >= int('a') && c <= int('z')) || (c >= int('A') && c <= int('Z'))))
				{
					all_latin = false;
					break;
				}
			}

			if (all_latin)
				cout << s << endl;
		}

		return 0;
	}

	cerr << "Unrecognized task - " << task << endl;

	return 1;
}
