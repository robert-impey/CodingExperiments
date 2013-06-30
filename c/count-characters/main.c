/**
 * Playing around with IO
 *
 * @copyright 2010-03-11, Robert Impey
 */

#include <stdio.h>

main()
{
	long nc;

	nc = 0;
	while (getchar() != EOF)
		nc++;

	printf("%ld\n", nc);
}
