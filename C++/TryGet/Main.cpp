#include <iostream>
#include <string>
#include "VowelCounting.h"

using namespace std;

void print_count(const string& word)
{
	const int count = vowel_counting::count_vowels(word);

	cout << "I found " << count << " vowels in '" << word << "'." << endl;
}

void print_validated_count(const string& word)
{
	int attempted_count;
	if (vowel_counting::try_count_vowels(word, attempted_count))
	{
		cout << "I found " << attempted_count << " vowels in '" << word << "'." << endl;
	}
	else {
		cout << "The word '" << word << "' is not valid." << endl;
	}
}

int main()
{
	const string with_vowels = "banana";
	const string without_vowels = "bcdf";
	const string with_numbers = "de4d";

	print_count(with_vowels);
	print_count(without_vowels);
	print_count(with_numbers);

	print_validated_count(with_vowels);
	print_validated_count(without_vowels);
	print_validated_count(with_numbers);

	return 0;
}