// ModifyString.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using std::cout;
using std::endl;
using std::string;

void modify_string(string text)
{
    // This won't compile
    //text[0] = "Z";
}

void modify_string_pointer(string* text)
{
    text[0] = "Z";
}

void modify_cstr(const char* text)
{
    // This won't compile
    //text[0] = "Z";
}

int main()
{
    string text("Through the Looking Glass");

    cout << text << endl;

    modify_string(text);

    cout << text << endl;

    // This fails at run time
    //modify_string_pointer(&text);

    cout << text << endl;

    modify_cstr(text.c_str());

    cout << text << endl;
}
