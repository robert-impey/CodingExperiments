#include <iostream>
#include <string>

using namespace std;

bool isVowel(char c)
{
	return c == 'a'
		|| c == 'e'
		|| c == 'i'
		|| c == 'o'
		|| c == 'u';
}

bool isDigit(char c)
{
	return c == '0'
		|| c == '1'
		|| c == '2'
		|| c == '3'
		|| c == '4'
		|| c == '5'
		|| c == '6'
		|| c == '7'
		|| c == '8'
		|| c == '9';
}

int countVowels(string word)
{
	int count = 0;

	string::iterator it;
	for (it = word.begin(); it < word.end(); it++)
	{
		if (isVowel(*it))
		{
			count++;
		}

		if (isdigit(*it))
		{
			return -1;
		}
	}

	return count;
}

bool tryCountVowels(string word, int &count)
{
	count = countVowels(word);

	return count >= 0;
}

void printCount(string word)
{
	int count = countVowels(word);

	cout << "I found " << count << " vowels in '" << word << "'." << endl;
}

void printValidatedCount(string word)
{
	int attemptedCount;
	if (tryCountVowels(word, attemptedCount))
	{
		cout << "I found " << attemptedCount << " vowels in '" << word << "'." << endl;
	}
	else {
		cout << "The '" << word << "' is not valid." << endl;
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