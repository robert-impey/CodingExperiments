#include <iostream>
#include <stdio.h>

using std::cout;
using std::endl;

int j;

void init()
{
	j = 0;
}

bool check()
{
	return j < 10;
}

void incr()
{
	j++;
}

int main()
{
	cout << "i" << endl;

	for (int i = 0; i < 10; i++) {
		printf("i - %d\n", i);
	}

	cout << "j" << endl;

	for (init(); check(); incr())
	{
		printf("j - %d\n", j);
	}

	return 0;
}
