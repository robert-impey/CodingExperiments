/**
 * A program for reversing the content of text files.
 * 
 * Using code from
 * http://en.wikipedia.org/wiki/Stack_(data_structure)
 *
 * @copyright 2010-10-17, Robert Impey
 */

#include <stdio.h>

typedef struct stack {
	char data;
	struct stack *next;
} STACK;

void push(STACK **head, char value)
{
	STACK *node = malloc(sizeof(STACK));  /* create a new node */

	if (node == NULL){
		fputs("Error: no space available for node\n", stderr);
		abort();
	} else {                                      /* initialize node */
		node->data = value;
		node->next = empty(*head) ? NULL : *head; /* insert new head if any */
		*head = node;
	}
}

int pop(STACK **head)
{
	if (empty(*head)) {                          /* stack is empty */
		fputs("Error: stack underflow\n", stderr);
		abort();
	} else {                                     /* pop a node */
		STACK *top = *head;
		char value = top->data;
		*head = top->next;
		free(top);
		return value;
	}
}

int main()
{
	char c;
	while (c = getchar() != EOF) {
		push(stack, c);
	}

	while (!empty(*stack)) {
		print(pop(stack));
	}

	return 0;
}

