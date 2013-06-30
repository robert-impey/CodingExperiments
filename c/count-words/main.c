/**
 * A little program to count the words in a text file.
 *
 * @copyright 2010-03-11, Robert Impey
 */

#include <stdio.h>

#define TRUE 1
#define FALSE 0

main()
{
	int c;
	long nw;
	int in_a_word;
	
	in_a_word = FALSE;
	nw = 0;
	while ((c = getchar()) != EOF) {
		if (c == ' ' || c == '\n' || c == '\r' || c == '\t')
			in_a_word = FALSE;
		else if (in_a_word == FALSE) {
			in_a_word = TRUE;
			nw++;
		}
	}
	
	printf("%ld\n", nw);
}

