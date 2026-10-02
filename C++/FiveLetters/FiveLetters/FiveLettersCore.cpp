#include "FiveLettersCore.h"

#include <algorithm>
#include <functional>
#include <iostream>
#include <set>
#include <sstream>
#include <unordered_map>
#include <utility>
#include <vector>

namespace fiveletters
{
	using namespace std;

	void find_5_letter_words(istream& input, ostream& output)
	{
		string s;
		while (input >> s)
		{
			if (s.size() == 5)
				output << s << endl;
		}
	}

	void remove_words_with_non_latin(istream& input, ostream& output)
	{
		string s;
		while (input >> s)
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
				output << s << endl;
		}
	}

	void to_upper(istream& input, ostream& output)
	{
		string s;
		auto diff = int('A') - int('a');

		while (input >> s)
		{
			for (auto c : s)
			{
				if (c >= int('a') && c <= int('z'))
					output << (char)(c + diff);
				else
					output << c;
			}

			output << endl;
		}
	}

	void sort(istream& input, ostream& output)
	{
		string s;
		vector<string> v;

		while (input >> s)
			v.push_back(s);

		std::sort(v.begin(), v.end());

		for (const auto& sr : v)
			output << sr << endl;
	}

	void remove_duplicates(istream& input, ostream& output)
	{
		string s;
		set<string> ss;

		while (input >> s)
			ss.insert(s);

		vector<string> sorted;
		for (auto& it : ss)
			sorted.push_back(it);

		std::sort(sorted.begin(), sorted.end());
		for (auto& it : sorted)
			output << it << endl;
	}

	void all_different(istream& input, ostream& output)
	{
		string s;

		while (input >> s)
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
				output << s << endl;
		}
	}

	void anagrams_to_sorted(istream& input, ostream& output)
	{
		string s;
		unordered_map<string, vector<string>> anagrams;

		while (input >> s) {
			auto sorted = s;
			std::sort(sorted.begin(), sorted.end());
			anagrams[sorted].push_back(s);
		}

		vector<string> keys;
		keys.reserve(anagrams.size());
		for (auto& it : anagrams)
			keys.push_back(it.first);

		std::sort(keys.begin(), keys.end());
		for (auto& it : keys) {
			output << it << ": ";
			for (auto& word : anagrams[it])
				output << word << " ";
			output << endl;
		}
	}

	vector<AllDiffGrid> find_all_diff_grids(
		const unordered_map<string, vector<string>>& anagrams)
	{
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

		vector<string> keys;
		keys.reserve(anagrams.size());
		for (const auto& entry : anagrams) {
			unsigned int mask;
			if (get_letter_mask(entry.first, mask) && !entry.second.empty())
				keys.push_back(entry.first);
		}
		std::sort(keys.begin(), keys.end());

		vector<string> selected;
		vector<AllDiffGrid> grids;
		function<void(size_t, unsigned int)> find_grids = [&](size_t start, unsigned int used_mask) {
			if (selected.size() == 5) {
				AllDiffGrid grid;
				for (size_t i = 0; i < selected.size(); ++i) {
					grid.keys[i] = selected[i];
					grid.words[i] = anagrams.at(selected[i]);
				}
				for (auto letter = 'A'; letter <= 'Z'; ++letter) {
					if ((used_mask & (1u << (letter - 'A'))) == 0) {
						grid.spare_letter = letter;
						break;
					}
				}
				grids.push_back(std::move(grid));
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
		return grids;
	}

	void all_diff_to_grid(istream& input, ostream& output)
	{
		unordered_map<string, vector<string>> anagrams;
		string line;

		while (getline(input, line)) {
			auto colon = line.find(':');
			if (colon == string::npos)
				continue;

			istringstream key_stream(line.substr(0, colon));
			string key;
			if (!(key_stream >> key))
				continue;

			std::sort(key.begin(), key.end());

			istringstream words_stream(line.substr(colon + 1));
			string word;
			while (words_stream >> word)
				anagrams[key].push_back(word);
		}

		for (const auto& grid : find_all_diff_grids(anagrams)) {
			for (size_t i = 0; i < grid.keys.size(); ++i) {
				output << grid.keys[i] << ":";
				for (const auto& word : grid.words[i])
					output << " " << word;
				output << endl;
			}
			output << grid.spare_letter << endl << endl;
		}
	}

	int run_task(const string& task, istream& input, ostream& output)
	{
		if (task == "find_5_letter_words") {
			find_5_letter_words(input, output);
			return 0;
		}

		if (task == "remove_words_with_non_latin") {
			remove_words_with_non_latin(input, output);
			return 0;
		}

		if (task == "to_upper") {
			to_upper(input, output);
			return 0;
		}

		if (task == "sort") {
			sort(input, output);
			return 0;
		}

		if (task == "remove_duplicates") {
			remove_duplicates(input, output);
			return 0;
		}

		if (task == "all_different") {
			all_different(input, output);
			return 0;
		}

		if (task == "anagrams_to_sorted") {
			anagrams_to_sorted(input, output);
			return 0;
		}

		if (task == "all_diff_to_grid") {
			all_diff_to_grid(input, output);
			return 0;
		}

		cerr << "Unrecognized task - " << task << endl;
		return 1;
	}
}
