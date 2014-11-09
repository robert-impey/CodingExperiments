// G4GAlgPrac1.cpp : main project file.

// See http://www.geeksforgeeks.org/algorithm-practice-question-beginners-set-1/
// 2014-11-09

#include "stdafx.h"
#include <stdio.h>

using namespace System;

unsigned fun0 (unsigned n)
{
	if (n == 0) return 1;
	if (n == 1) return 2;

	return fun0(n - 1) + fun0(n - 1);
}

int main(array<System::String ^> ^args)
{
	for (int i = 0; i <= 10; i++)
	{
		printf("fun0(%d) - %d\n", i, fun0(i));
	}

	return 0;
}
