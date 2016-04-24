#include <stdio.h>

int main()
{
	int c, nl;

	bool in_line_ending, error_found;
	in_line_ending = error_found = false;

	nl = 0;

	while ((c = getchar()) != EOF) {
		if (in_line_ending) {
			in_line_ending = false;

			if (c == '\n') {
				nl++;
			}
			else {
				error_found = true;
				break;
			}
		}
		else {
			if (c == '\r') {
				in_line_ending = true;
			}
		}
	}

	if (error_found) {
		printf("This file has non-Windows line endings!");
	}
	else {
		printf("Windows line endings found: %d\n", nl);
	}
}
