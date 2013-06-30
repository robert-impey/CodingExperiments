/**
 * Playing around with IO
 *
 * @copyright 2010-03-11, Robert Impey
 */

#include <stdio.h>

main()
{
	int c;
	
	while ((c = getchar()) != EOF)
		putchar(c);
}
