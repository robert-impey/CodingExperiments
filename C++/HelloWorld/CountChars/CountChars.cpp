// CountChars.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <map>

using namespace std;

int main()
{
	string text("Alice's Adventures in Wonderland");
	map<char, int> counts;

	for (auto cur_char : text)
	{
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
