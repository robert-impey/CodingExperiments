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

int main(int argc, char **argv)
{
    if (argc > 1) {
        struct Node *head;

        int i;
        for (i = argc - 1; i > 0; i--) {
            int current_arg = atoi(argv[i]);

            struct Node *temp;

            temp = (struct Node *)malloc(sizeof (struct Node));
            temp->Data = current_arg;

            if (head == NULL) {
                head = temp;
                head->Next = NULL;
            } else {
                temp->Next = head;
                head = temp;
            }
        }

        struct Node *current;
        current = head;
        while (1) {
            printf("%d", current->Data);
            if (current->Next == NULL) {
                printf("\n");
                break;
            } else {
                printf(" ");
                current = current->Next;
            }
        }
    }

    return 0;
}

