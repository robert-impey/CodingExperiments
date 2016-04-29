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

int main()
{
	string withVowels = "banana";
	string withoutVowels = "bcdf";
	string withNumbers = "de4d";

	int countWithVowels = countVowels(withVowels);
	cout << "Count of string with vowels: " << countWithVowels << endl;

	int countWithoutVowels = countVowels(withoutVowels);
	cout << "Count of string without vowels: " << countWithoutVowels << endl;

	int countWithNumbers = countVowels(withNumbers);
	cout << "Count of string with numbers: " << countWithNumbers << endl;

	return 0;
}