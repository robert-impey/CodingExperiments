#define main FiveLettersEntryPoint
#include "../FiveLetters/FiveLetters.cpp"
#undef main

#include <gtest/gtest.h>

#include <chrono>
#include <filesystem>
#include <fstream>
#include <string>

TEST(FiveLettersCommandLine, StopsAfterNamedTask)
{
	namespace fs = std::filesystem;
	const auto unique_id = std::chrono::steady_clock::now().time_since_epoch().count();
	const auto root = fs::temp_directory_path() / ("FiveLettersMainTests-" + std::to_string(unique_id));
	const auto input_dir = root / "input";
	const auto output_dir = root / "output";
	fs::create_directories(input_dir);
	{
		std::ofstream input(input_dir / "british-english.txt");
		input << "apple\n";
	}

	char executable[] = "FiveLetters";
	char task_option[] = "--task";
	char task_name[] = "to_upper";
	auto input_path = input_dir.string();
	auto output_path = output_dir.string();
	char* arguments[] = { executable, task_option, task_name, input_path.data(), output_path.data() };

	const auto exit_code = FiveLettersEntryPoint(5, arguments);

	EXPECT_EQ(exit_code, 0);
	EXPECT_TRUE(fs::exists(output_dir / "five-letter-words-all-latin-upper.txt"));
	EXPECT_FALSE(fs::exists(output_dir / "sorted.txt"));
	fs::remove_all(root);
}
