#include <iostream>
#include <string>

#include "Funcs.h"

using namespace std;

string f();

int main(int argc, char *argv[])
{
	string s;

	cout << s << endl;

	string myF = f();

	cout << myF << endl;

	string myG = Funcs::g();

	cout << myG << endl;

	return 0;
}

string f()
{
	return "f";
}
