/**
 * For counting the number of links in an HTML file.
 *
 * @copyright 2010-03-11, Robert Impey
 */

#include <stdio.h>

#define IN 1
#define OUT 0

main()
{
	int c, pc; /* The current and previous char */
	long nl;
	int tag_state, anchor_state;
	
	tag_state = OUT;
	anchor_state = OUT;
	
	nl = 0;
	while ((c = getchar()) != EOF) {
		switch (c) {
			case '<':
				if (tag_state == OUT)
					tag_state = IN;
				break;
			case '>':
				if (tag_state == IN)
					tag_state = OUT;
				if (anchor_state == IN)
					anchor_state = OUT;
				break;
			case 'a':
			case 'A':
				if (tag_state == IN)
					if (pc == '<') {
						anchor_state = IN;
						nl++;
					}
				break;
		}
		
		pc = c;
	}
	
	printf("%ld\n", nl);
}
