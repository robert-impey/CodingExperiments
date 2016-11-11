#include <iostream>
#include <string>
#include "VowelCounting.h"

using namespace std;

void printCount(string word)
{
	int count = VowelCounting::countVowels(word);

	cout << "I found " << count << " vowels in '" << word << "'." << endl;
}

void printValidatedCount(string word)
{
	int attemptedCount;
	if (VowelCounting::tryCountVowels(word, attemptedCount))
	{
		cout << "I found " << attemptedCount << " vowels in '" << word << "'." << endl;
	}
	else {
		cout << "The word '" << word << "' is not valid." << endl;
	}
}

int main()
{
	string withVowels = "banana";
	string withoutVowels = "bcdf";
	string withNumbers = "de4d";

	printCount(withVowels);
	printCount(withoutVowels);
	printCount(withNumbers);

	printValidatedCount(withVowels);
	printValidatedCount(withoutVowels);
	printValidatedCount(withNumbers);

	return 0;
}