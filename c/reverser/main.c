/**
 * A program for reversing the content of text files.
 * 
 * Using code from
 * http://en.wikipedia.org/wiki/Stack_(data_structure)
 *
 * @copyright 2010-10-17, Robert Impey
 */

#include <stdlib.h>
#include <stdio.h>

typedef struct frame 
{
    char data;
    struct frame *next;
} FRAME;

typedef struct stack
{
    FRAME *top;
} STACK;

int is_empty(STACK *stack)
{
    return stack->top == NULL ? 1 : 0;
}

int is_bottom(FRAME *frame)
{
    return frame->next == NULL ? 1 : 0;
}

FRAME *make_frame(char data)
{
    FRAME *frame = malloc(sizeof(FRAME));

    frame->data = data;
    frame->next = NULL;

    return frame;
}

STACK *make_stack()
{
    STACK *stack = malloc(sizeof(STACK));

    stack->top = NULL;

    return stack;
}

void push(STACK *stack, char value)
{
    FRAME *new_frame = make_frame(value);

    if (is_empty(stack) == 0)
    {
        new_frame->next = stack->top;
    }

    stack->top = new_frame;
}

char pop(STACK *stack)
{
    if (is_empty(stack) == 1) {                          /* stack is empty */
        fputs("Error: stack underflow\n", stderr);
        abort();
    } else {                                     /* pop a node */
        FRAME *top = stack->top;

        char value = top->data;

        stack->top = top->next;
        free(top);

        return value;
    }
}


int main()
{
    STACK *stack = make_stack();

    char c;
    while ((c = getchar()) != EOF) {
        push(stack, c);
    }
	
    while (is_empty(stack) != 1) {
        printf("%c", pop(stack));
    }
	
    return 0;
}

