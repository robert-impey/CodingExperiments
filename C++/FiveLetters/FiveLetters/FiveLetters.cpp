// FiveLetters.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <fstream>
#include <vector>
#include <algorithm>
#include <unordered_map>
#include <set>
#include <sstream>
#include <functional>

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
		
		return 0;
	}

	if (task == "remove_duplicates") {
		string s;
		set<string> ss;

		while (cin >> s)
		{
			ss.insert(s);
		}

		vector<string> sorted;
		for (auto& it : ss) {
			sorted.push_back(it);
		}

		sort(sorted.begin(), sorted.end());
		for (auto& it : sorted) {
			cout << it << endl;
		}

		return 0;
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

		return 0;
	}

	if (task == "anagrams_to_sorted") {
		string s;
		unordered_map<string, vector<string>> anagrams;

		while (cin >> s) {
			auto sorted = s;
			sort(sorted.begin(), sorted.end());

			anagrams[sorted].push_back(s);
		}

		vector<string> keys;
		keys.reserve(anagrams.size());

		for (auto& it : anagrams) {
			keys.push_back(it.first);
		}

		sort(keys.begin(), keys.end());

		for (auto& it : keys) {
			cout << it << ": ";
			for (auto& word : anagrams[it]) {
				cout << word << " ";
			}
			cout << endl;
		}

		return 0;
	}

	if (task == "all_diff_to_grid") {
		unordered_map<string, vector<string>> anagrams;
		string line;

		auto get_letter_mask = [](const string& key, unsigned int& mask) {
			if (key.size() != 5)
				return false;

			mask = 0;
			for (auto c : key) {
				if (c >= 'A' && c <= 'Z')
					c = char(c - 'A' + 'a');
				if (c < 'a' || c > 'z')
					return false;

				auto bit = 1u << (c - 'a');
				if ((mask & bit) != 0)
					return false;
				mask |= bit;
			}

			return true;
		};

		while (getline(cin, line)) {
			auto colon = line.find(':');
			if (colon == string::npos)
				continue;

			istringstream key_stream(line.substr(0, colon));
			string key;
			if (!(key_stream >> key))
				continue;

			sort(key.begin(), key.end());
			unsigned int mask;
			if (!get_letter_mask(key, mask))
				continue;

			istringstream words_stream(line.substr(colon + 1));
			string word;
			while (words_stream >> word)
				anagrams[key].push_back(word);
		}

		vector<string> keys;
		keys.reserve(anagrams.size());
		for (const auto& entry : anagrams)
			keys.push_back(entry.first);
		sort(keys.begin(), keys.end());

		vector<string> selected;
		function<void(size_t, unsigned int)> find_grids = [&](size_t start, unsigned int used_mask) {
			if (selected.size() == 5) {
				for (const auto& key : selected) {
					cout << key << ":";
					for (const auto& word : anagrams[key])
						cout << " " << word;
					cout << endl;
				}

				for (auto letter = 'A'; letter <= 'Z'; ++letter) {
					if ((used_mask & (1u << (letter - 'A'))) == 0) {
						cout << letter << endl << endl;
						break;
					}
				}
				return;
			}

			for (auto i = start; i < keys.size(); ++i) {
				unsigned int key_mask;
				get_letter_mask(keys[i], key_mask);
				if ((used_mask & key_mask) != 0)
					continue;

				selected.push_back(keys[i]);
				find_grids(i + 1, used_mask | key_mask);
				selected.pop_back();
			}
		};

		find_grids(0, 0);
		return 0;
	}

	cerr << "Unrecognized task - " << task << endl;

	return 1;
}
