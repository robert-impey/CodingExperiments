// CountChars.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using std::cout;
using std::endl;

int main()
{
    std::string text("Alice in Wonderland");

    for (auto i = 0; i < text.size(); i++)
    {
        cout << text[i] << endl;
    }
}
