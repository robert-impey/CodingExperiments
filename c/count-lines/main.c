/**
 * A little program to count the lines of a text file on various platforms.
 *
 * @copyright 2010-03-11, Robert Impey
 */

#include <stdio.h>

#define TRUE 1
#define FALSE 0

main()
{
	int c;
	long nl;
	int at_beginning_of_line, might_be_windows_new_line;
	
	at_beginning_of_line = TRUE;
	might_be_windows_new_line = FALSE;
	
	nl = 0;
	while ((c = getchar()) != EOF) {
		if (at_beginning_of_line) {
			nl++;
			
			at_beginning_of_line = FALSE;
		}
		
		if (c == '\n' || c == '\r') {
			at_beginning_of_line = TRUE;
		}
		
		if (c == '\n') {
			might_be_windows_new_line = TRUE;
		}
	}
	
	printf("%ld\n", nl);
}
