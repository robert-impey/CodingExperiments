/**
 * Experimenting with Singly Linkled Lists.
 *
 * Using Code from http://codingfreak.blogspot.com/2009/08/implementation-of-singly-linked-list-in.html
 *
 * @copyright 2013-08-30, Robert Impey
 */

#include <stdio.h>
#include <stdlib.h>

struct Node
{
    int Data;
    struct Node *Next;
};

struct Node *make_linked_list_from_args(int args_start, int args_length, char **args)
{
    struct Node *head;

    int i;
    for (i = args_length - 1; i >= args_start; i--) {
        int current_arg = atoi(args[i]);

        struct Node *temp;

        temp = (struct Node *)malloc(sizeof (struct Node));
        temp->Data = current_arg;

        if (i == args_length - 1) {
            head = temp;
            head->Next = NULL;
        } else {
            temp->Next = head;
            head = temp;
        }
    }

    return head;
}

void print_linked_list(struct Node *current)
{
    while (1) {
        printf("%d", current->Data);
        if (current->Next == NULL) {
            printf("\n");
            return;
        } else {
            printf(" ");
            current = current->Next;
        }
    }
}

int main(int argc, char **argv)
{
    if (argc > 1) {
        struct Node *head = make_linked_list_from_args(1, argc, argv);

        print_linked_list(head);
    }

    return 0;
}

