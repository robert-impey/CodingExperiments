#include <stdio.h>

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
	int i;

	for (i = 0; i < 10; i++) {
		printf("i - %d\n", i);
	}

	for (init(); check(); incr())
	{
		printf("j - %d\n", j);
	}

	return 0;
}
