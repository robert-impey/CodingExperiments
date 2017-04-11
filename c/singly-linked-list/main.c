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

struct LinkedList
{
    struct Node *Head;
};

struct LinkedList *make_linked_list()
{
    struct LinkedList *linked_list;

    linked_list = (struct LinkedList *)malloc(sizeof (struct LinkedList));

    linked_list->Head = NULL;

    return linked_list;
}

int is_final(struct Node *head)
{
    return head->Next == NULL ? 1 : 0;
}

int is_empty(struct LinkedList *linked_list)
{
    return linked_list == NULL || linked_list->Head == NULL ? 1 : 0;
}

struct Node *make_node(int data)
{
    struct Node *node;

    node = (struct Node *)malloc(sizeof (struct Node));

    node->Data = data;
    node->Next = NULL;

    return node;
}

void add_node_to_linked_list(struct LinkedList *linked_list, struct Node *addendum)
{
    if (is_empty(linked_list) == 1)
    {
        linked_list->Head = addendum;
    }
    else
    {
        addendum->Next = linked_list->Head;
        linked_list->Head = addendum;
    }
}

struct LinkedList *make_linked_list_from_args(int args_start, int args_length, char **args)
{
    struct LinkedList *linked_list = make_linked_list();

    int i;
    for (i = args_length - 1; i >= args_start; i--) {
        int current_arg = atoi(args[i]);

        struct Node *temp;

        temp = make_node(current_arg);

        add_node_to_linked_list(linked_list, temp);
    }

    return linked_list;
}

void print_linked_list(struct LinkedList *linked_list)
{
    if (is_empty(linked_list) == 0)
    {
        struct Node *current;

        current = linked_list->Head;

        int reached_end = 0;
        while (reached_end == 0) {
            printf("%d", current->Data);
            if (is_final(current) == 1) {
                printf("\n");
                reached_end = 1;
            } else {
                printf(" ");
                current = current->Next;
            }
        }
    }
}

int main(int argc, char **argv)
{
    if (argc > 1) {
        struct LinkedList *linked_list = make_linked_list_from_args(1, argc, argv);

        print_linked_list(linked_list);
    }

    return 0;
}

