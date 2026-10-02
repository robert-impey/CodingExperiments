#pragma once

#include <iosfwd>
#include <string>

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
	void all_diff_to_grid(std::istream& input, std::ostream& output);
}
