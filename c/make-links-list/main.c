/**
 * Reads a CSV file and produces an HTML list of links.
 *
 * Using code from
 * 	http://codingfreak.blogspot.com/2009/08/implementation-of-singly-linked-list-in.html
 *
 * @copyright 2010-03-11, Robert Impey
 */

#include <stdio.h>

#define TRUE 1
#define FALSE 0

#define IN 1
#define OUT 0

struct node
{
	int data;
	struct node *next;
}*Head;

/* Adding a Node at the end of the list */

append(int num)
{
   struct node *temp,*r;

   temp=(struct node *)malloc(sizeof(struct node));
   temp->data=num;

   /* Copying the Head location into another node. */
   r=Head;

   if (Head == NULL) /* If List is empty we create First Node. */
   {
	  Head=temp;
	  Head->next =NULL;
   }
   else
   {       // Traverse down to end of the list. 
	  while(r->next != NULL)
	  r=r->next;
	  
	  // Appending at the end of the list.
	  temp->next=NULL;
	  r->next =temp;  
   }
}


main()
{
	int c; /* The current char */
	int at_start, address_state;
	
	at_start = TRUE;
	address_state = IN;
	
	while ((c = getchar()) != EOF) {
		if (at_start == TRUE) {
			printf("<ul>\n\t<li><a href=\"");
			
			at_start = FALSE;
		}
		
		switch (c) {
			case '\n':
				address_state = IN;
				
				printf("</a></li>\n");
				
				break;
			case ',':
				if (address_state == IN) {
					printf("\">");
					
					address_state = OUT;
				}
				break;
			default:
				putchar(c);
		}
	}
	
	printf("</ul>\n");
}
