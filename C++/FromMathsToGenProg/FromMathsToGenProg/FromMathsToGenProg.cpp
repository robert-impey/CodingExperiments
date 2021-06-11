// FromMathsToGenProg.cpp : Defines the entry point for the application.
//

#include "FromMathsToGenProg.h"

using namespace std;

int multiply0(int n, int a)
{
	if (n == 1) return a;
	return multiply0(n - 1, a) + a;
}

int main()
{
	cout << multiply0(5, 10) << endl;
	return 0;
}
