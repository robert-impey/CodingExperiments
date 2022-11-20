// FiveLetters.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>

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

	if (task == "to_upper") {
		string s;
		auto diff = int('A') - int('a');

		while (cin >> s)
		{
			for (auto c : s)
			{
				if (c >= int('a') && c <= int('z'))
				{
					cout << (char)(c + diff);
				}
				else
				{
					cout << c;
				}
			}

			cout << endl;
		}

		return 0;
	}

	if (task == "sort") {
		string s;

		vector<string> v;

		while (cin >> s)
		{
			v.push_back(s);
		}

		sort(v.begin(), v.end());

		for (const auto& sr : v)
			cout << sr << endl;
	}

	if (task == "remove_duplicates") {
		string s, previous;
		auto first = true;

		while (cin >> s)
		{
			if (first)
			{
				cout << s << endl;
				first = false;
			}
			else
			{
				if (s != previous)
					cout << s << endl;
			}

			s = previous;
		}
	}

	if (task == "all_different") {
		string s;

		while (cin >> s)
		{
			auto all_different = true;
			for (auto i = 0; all_different && i < 4; i++)
			{
				for (auto j = i + 1; all_different && j < 5; j++)
				{
					if (s[i] == s[j])
						all_different = false;
				}
			}

			if (all_different)
				cout << s << endl;
		}
	}

	cerr << "Unrecognized task - " << task << endl;

	return 1;
}
