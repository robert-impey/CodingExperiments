#include "FiveLettersCore.h"

#include <gtest/gtest.h>

#include <sstream>
#include <string>

namespace
{
	struct TaskResult
	{
		int exit_code;
		std::string output;
	};

	TaskResult run(const std::string& task, const std::string& input_text)
	{
		std::istringstream input(input_text);
		std::ostringstream output;
		const auto exit_code = fiveletters::run_task(task, input, output);
		return { exit_code, output.str() };
	}
}

TEST(FiveLettersTasks, FindsOnlyFiveLetterWords)
{
	const auto result = run("find_5_letter_words", "apple pear grape plum\n");

	EXPECT_EQ(result.exit_code, 0);
	EXPECT_EQ(result.output, "apple\ngrape\n");
}

TEST(FiveLettersTasks, RemovesWordsContainingNonLatinCharacters)
{
	const auto result = run("remove_words_with_non_latin", "hello abc1 caf\xC3\xA9 world\n");

	EXPECT_EQ(result.exit_code, 0);
	EXPECT_EQ(result.output, "hello\nworld\n");
}

TEST(FiveLettersTasks, ConvertsLowercaseLettersToUppercase)
{
	const auto result = run("to_upper", "hello\n");

	EXPECT_EQ(result.exit_code, 0);
	EXPECT_EQ(result.output, "HELLO\n");
}

TEST(FiveLettersTasks, RemovesDuplicatesAndSortsWords)
{
	const auto result = run("remove_duplicates", "pear apple pear banana apple\n");

	EXPECT_EQ(result.exit_code, 0);
	EXPECT_EQ(result.output, "apple\nbanana\npear\n");
}

TEST(FiveLettersTasks, KeepsOnlyWordsWithAllDistinctLetters)
{
	const auto result = run("all_different", "abcde apple hello world\n");

	EXPECT_EQ(result.exit_code, 0);
	EXPECT_EQ(result.output, "abcde\nworld\n");
}

TEST(FiveLettersTasks, SortsWords)
{
	const auto result = run("sort", "pear apple banana\n");

	EXPECT_EQ(result.exit_code, 0);
	EXPECT_EQ(result.output, "apple\nbanana\npear\n");
}

TEST(FiveLettersTasks, GroupsAnagramsUnderSortedKeys)
{
	const auto result = run("anagrams_to_sorted", "silent listen hello\n");

	EXPECT_EQ(result.exit_code, 0);
	EXPECT_EQ(result.output, "ehllo: hello \neilnst: silent listen \n");
}

TEST(FiveLettersTasks, GeneratesGridsFromDistinctAnagramKeys)
{
	const std::string input_data =
		"abcde: abcde\n"
		"fghij: fghij\n"
		"klmno: klmno\n"
		"pqrst: pqrst\n"
		"uvwxy: uvwxy\n";

	const auto result = run("all_diff_to_grid", input_data);

	EXPECT_EQ(result.exit_code, 0);
	const std::string expected_output =
		"abcde: abcde\n"
		"fghij: fghij\n"
		"klmno: klmno\n"
		"pqrst: pqrst\n"
		"uvwxy: uvwxy\n"
		"Z\n\n";
	EXPECT_EQ(result.output, expected_output);
}

TEST(FiveLettersTasks, ReturnsErrorOnUnrecognizedTask)
{
	const auto result = run("non_existent_task", "test\n");

	EXPECT_EQ(result.exit_code, 1);
}

TEST(FiveLettersDirectMethods, CallsIndividualTaskMethodsDirectly)
{
	std::istringstream input("apple pear grape plum\n");
	std::ostringstream output;
	fiveletters::find_5_letter_words(input, output);
	EXPECT_EQ(output.str(), "apple\ngrape\n");
}
