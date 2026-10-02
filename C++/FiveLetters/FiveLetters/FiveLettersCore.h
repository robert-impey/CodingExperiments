#pragma once

#include <array>
#include <iosfwd>
#include <string>
#include <unordered_map>
#include <vector>

namespace fiveletters
{
	int run_task(const std::string& task, std::istream& input, std::ostream& output);

	void find_5_letter_words(std::istream& input, std::ostream& output);
	void remove_words_with_non_latin(std::istream& input, std::ostream& output);
	void to_upper(std::istream& input, std::ostream& output);
	void sort(std::istream& input, std::ostream& output);
	void remove_duplicates(std::istream& input, std::ostream& output);
	void all_different(std::istream& input, std::ostream& output);
	void anagrams_to_sorted(std::istream& input, std::ostream& output);

	struct AllDiffGrid
	{
		std::array<std::string, 5> keys;
		std::array<std::vector<std::string>, 5> words;
		char spare_letter;
	};

	std::vector<AllDiffGrid> find_all_diff_grids(
		const std::unordered_map<std::string, std::vector<std::string>>& anagrams);
	void all_diff_to_grid(std::istream& input, std::ostream& output);
}
