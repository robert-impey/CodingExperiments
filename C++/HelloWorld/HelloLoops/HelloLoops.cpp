#include <iostream>
#include <cstdio>

using std::cout;
using std::endl;

int j;

void init()
{
	j = 5;
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

	for (auto i = 0; i < 10; i++) {
		printf("i - %d\n", i);
	}

	cout << "j with for loop" << endl;

	for (init(); check(); incr())
	{
		printf("j - %d\n", j);
	}

	cout << "j with Go! style for loop" << endl;

	init();
	for (; check();)
	{
		printf("j - %d\n", j);
		incr();
	}

	cout << "j with while loop" << endl;

	init();
	while (check())
	{
		printf("j - %d\n", j);
		incr();
	}

	return 0;
}
