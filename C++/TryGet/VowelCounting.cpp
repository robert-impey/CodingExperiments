#include <string>
#include "VowelCounting.h"

using namespace std;

bool is_vowel(const char c)
{
	return c == 'a'
		|| c == 'e'
		|| c == 'i'
		|| c == 'o'
		|| c == 'u';
}

bool is_digit(const char c)
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

int vowel_counting::count_vowels(string word)
{
	int count = 0;

	for (auto it = word.begin(); it < word.end(); ++it)
	{
		if (is_vowel(*it))
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

bool vowel_counting::try_count_vowels(const string& word, int &count)
{
	count = count_vowels(word);

	return count >= 0;
}
