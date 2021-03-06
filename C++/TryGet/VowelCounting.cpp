#include <string>
#include "VowelCounting.h"

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

int VowelCounting::countVowels(string word)
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

bool VowelCounting::tryCountVowels(string word, int &count)
{
	count = countVowels(word);

	return count >= 0;
}
