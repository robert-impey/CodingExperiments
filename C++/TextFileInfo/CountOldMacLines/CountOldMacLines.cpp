// CountOldMacLines.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int main()
{
	int c, nl;

	nl = 0;

	while ((c = getchar()) != EOF) {
		if (c == '\r') {
			nl++;
		}
	}

	printf("%d\n", nl);
}

