// ModifyString.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>

using namespace std;

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

void print_char_vect(const vector<char> v)
{
    for (auto c : v)
    {
        cout << c;
    }

    cout << endl;
}

void modify_char_vect(vector<char> v)
{
    v[0] = 'H';

    print_char_vect(v);
}

void modify_char_vect_ref(vector<char> v)
{
    v[0] = 'H';

    print_char_vect(v);
}

vector<char> modify_and_return_vect_ref(vector<char> v)
{
    v[0] = 'S';

    print_char_vect(v);

    return v;
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

    vector<char> text_vect { 'D', 'A', 'M' };

    print_char_vect(text_vect);

    modify_char_vect(text_vect);

    // This remains unchanged
    print_char_vect(text_vect);

    text_vect = modify_and_return_vect_ref(text_vect);

    print_char_vect(text_vect);
}
