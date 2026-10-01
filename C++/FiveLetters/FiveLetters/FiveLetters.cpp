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
#include <filesystem>
#include <stdexcept>
#include <CLI/CLI.hpp>

using namespace std;

static int run_task(const string& task, istream& input, ostream& output)
{
	if (task == "find_5_letter_words") {
		string s;
		while (input >> s)
		{
			if (s.size() == 5)
				output << s << endl;
		}

		return 0;
	}

	if (task == "remove_words_with_non_latin") {
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

		return 0;
	}

	if (task == "to_upper") {
		string s;
		auto diff = int('A') - int('a');

		while (input >> s)
		{
			for (auto c : s)
			{
				if (c >= int('a') && c <= int('z'))
				{
					output << (char)(c + diff);
				}
				else
				{
					output << c;
				}
			}

			output << endl;
		}

		return 0;
	}

	if (task == "sort") {
		string s;

		vector<string> v;

		while (input >> s)
		{
			v.push_back(s);
		}

		sort(v.begin(), v.end());

		for (const auto& sr : v)
			output << sr << endl;
		
		return 0;
	}

	if (task == "remove_duplicates") {
		string s;
		set<string> ss;

		while (input >> s)
		{
			ss.insert(s);
		}

		vector<string> sorted;
		for (auto& it : ss) {
			sorted.push_back(it);
		}

		sort(sorted.begin(), sorted.end());
		for (auto& it : sorted) {
			output << it << endl;
		}

		return 0;
	}

	if (task == "all_different") {
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

		return 0;
	}

	if (task == "anagrams_to_sorted") {
		string s;
		unordered_map<string, vector<string>> anagrams;

		while (input >> s) {
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
			output << it << ": ";
			for (auto& word : anagrams[it]) {
				output << word << " ";
			}
			output << endl;
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

		while (getline(input, line)) {
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
					output << key << ":";
					for (const auto& word : anagrams[key])
						output << " " << word;
					output << endl;
				}

				for (auto letter = 'A'; letter <= 'Z'; ++letter) {
					if ((used_mask & (1u << (letter - 'A'))) == 0) {
						output << letter << endl << endl;
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

int main(int argc, char* argv[])
{
	CLI::App app{ "Generate the five-letter word files." };
	string input_directory;
	string output_directory;
	app.add_option("input-dir", input_directory, "Directory containing british-english.txt")->required();
	app.add_option("output-dir", output_directory, "Directory for generated files")->required();

	CLI11_PARSE(app, argc, argv);

	try {
		const filesystem::path input_dir(input_directory);
		const filesystem::path output_dir(output_directory);
		filesystem::create_directories(output_dir);

		const vector<pair<string, string>> stages = {
			{ "british-english.txt", "five-letter-words.txt" },
			{ "five-letter-words.txt", "five-letter-words-all-latin.txt" },
			{ "five-letter-words-all-latin.txt", "five-letter-words-all-latin-upper.txt" },
			{ "five-letter-words-all-latin-upper.txt", "sorted.txt" },
			{ "sorted.txt", "unique-five-letter-words-all-latin-upper.txt" },
			{ "unique-five-letter-words-all-latin-upper.txt", "all-different.txt" },
			{ "all-different.txt", "anagrams.txt" },
			{ "anagrams.txt", "grids.txt" }
		};
		const vector<string> tasks = {
			"find_5_letter_words", "remove_words_with_non_latin", "to_upper", "sort",
			"remove_duplicates", "all_different", "anagrams_to_sorted", "all_diff_to_grid"
		};

		for (size_t i = 0; i < stages.size(); ++i) {
			const filesystem::path source = i == 0 ? input_dir / stages[i].first : output_dir / stages[i].first;
			const filesystem::path destination = output_dir / stages[i].second;
			if (filesystem::exists(destination))
				continue;

			ifstream input(source);
			if (!input)
				throw runtime_error("Cannot open input file: " + source.string());
			ofstream output(destination);
			if (!output)
				throw runtime_error("Cannot create output file: " + destination.string());
			if (run_task(tasks[i], input, output) != 0 || !input.eof() || !output)
				throw runtime_error("Failed while processing: " + source.string());
		}
	}
	catch (const exception& error) {
		cerr << error.what() << endl;
		return 1;
	}

	return 0;
}
