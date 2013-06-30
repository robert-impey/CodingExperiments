/**
 * A little program to read a text file from the standard input and
 * print each word that it finds on a new line.
 *
 * @copyright 2010-03-20, Robert Impey
 */

#include <stdio.h>

#define TRUE 1
#define FALSE 0

int main()
{
	int c;
	int in_a_word;
	
	in_a_word = FALSE;
	
	while ((c = getchar()) != EOF) {
		if (c == ' ' || c == '\t') {
			if (in_a_word == TRUE) {
				printf("\n");
			}
			
			in_a_word = FALSE;
		} else {
			in_a_word = TRUE;
			printf("%c", c);
		}
	}
}
