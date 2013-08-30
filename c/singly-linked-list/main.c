/**
 * Experimenting with Singly Linkled Lists.
 *
 * Using Code from http://codingfreak.blogspot.com/2009/08/implementation-of-singly-linked-list-in.html
 *
 * @copyright 2013-08-30, Robert Impey
 */

#include <stdio.h>

 struct Node
 {
   int Data;
   struct Node *Next;
 }; 

int main(int argc, char **argv)
{
	int i;
	for (i = 1; i < argc; i++) {
		printf("%d - %d\n", i, atoi(argv[i]));
	}
	
	printf("\n");
	
	return 0;
}
