#include <iostream>
#include <string>

using namespace std;

int countVowels(string word)
{
	int count = 0;

	string::iterator it;
	for (it = word.begin(); it < word.end(); it++)
	{
		if (*it == 'a'
			|| *it == 'e'
			|| *it == 'i'
			|| *it == 'o'
			|| *it == 'u')
		{
			count++;
		}

		if (*it == '0'
			|| *it == '1'
			|| *it == '2'
			|| *it == '3'
			|| *it == '4'
			|| *it == '5'
			|| *it == '6'
			|| *it == '7'
			|| *it == '8'
			|| *it == '9')
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