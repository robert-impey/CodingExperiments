/**
 * Playing around with IO
 *
 * @copyright 2010-10-19, Robert Impey
 */

#include <stdio.h>

main()
{
	char c;
	long nc;

	nc = 0;
	while ((c = getchar()) != EOF) {
		if (c == '\n') {
			nc++;
		}
	}
	
	printf("%ld\n", nc);
}

