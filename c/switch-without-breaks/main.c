/**
 * What happens when you leave out break statements in a switch?
 *
 * @copyright 2010-03-11, Robert Impey
 */

#include <stdio.h>

int main()
{
    int value = 1;

    switch (value)
    {
        case 1:
            printf("It's 1!\n");
        case 2:
        case 3:
            printf("It's 2 or 3!\n");
            break;
        default:
            printf("It's something else.\n");
    }

	return 0;
}
