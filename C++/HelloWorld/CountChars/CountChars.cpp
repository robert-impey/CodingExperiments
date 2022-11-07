// CountChars.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <map>

using std::cout;
using std::endl;

int main()
{
	std::string text("Alice's Adventures in Wonderland");
	std::map<char, int> counts;

	for (auto i = 0; i < text.size(); i++)
	{
		auto cur_char = text[i];

		cout << cur_char << endl;

		if (counts.count(cur_char))
		{
			counts[cur_char]++;
		}
		else
		{
			counts[cur_char] = 1;
		}
	}

	for (auto& count : counts)
	{
		cout << count.first << " " << count.second << endl;
	}
}
