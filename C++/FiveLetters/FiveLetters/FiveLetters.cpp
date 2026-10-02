// FiveLetters.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <fstream>
#include <iostream>
#include <vector>
#include <filesystem>
#include <stdexcept>
#include <utility>
#include <CLI/CLI.hpp>
#include "FiveLettersCore.h"

using namespace std;

int main(int argc, char* argv[])
{
	CLI::App app{ "Generate the five-letter word files." };
	string input_directory;
	string output_directory;
	int word_count = 5;
	app.add_option("input-dir", input_directory, "Directory containing british-english.txt")->required();
	app.add_option("output-dir", output_directory, "Directory for generated files")->required();
	app.add_option("--word-count", word_count, "Number of words in each generated grid")
		->check(CLI::Range(1, 5));

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
			{ "anagrams.txt", "grids-" + to_string(word_count) + ".txt" }
		};
		const vector<string> tasks = {
			"find_5_letter_words", "remove_words_with_non_latin", "to_upper", "sort",
			"remove_duplicates", "all_different", "anagrams_to_sorted", "all_diff_to_grid"
		};

		for (size_t i = 0; i < stages.size(); ++i) {
			const filesystem::path source = i == 0 ? input_dir / stages[i].first : output_dir / stages[i].first;
			const filesystem::path destination = output_dir / stages[i].second;
			if (filesystem::exists(destination) && i != stages.size() - 1)
				continue;

			ifstream input(source);
			if (!input)
				throw runtime_error("Cannot open input file: " + source.string());
			ofstream output(destination);
			if (!output)
				throw runtime_error("Cannot create output file: " + destination.string());
			if (fiveletters::run_task(tasks[i], input, output, word_count) != 0 || !input.eof() || !output)
				throw runtime_error("Failed while processing: " + source.string());
		}
	}
	catch (const exception& error) {
		cerr << error.what() << endl;
		return 1;
	}

	return 0;
}
