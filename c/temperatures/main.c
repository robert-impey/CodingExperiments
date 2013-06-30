/**
 * Temperature Conversions
 *
 * @copyright 2010-03-11, Robert Impey
 */

#include <stdio.h>

#define LOWER 0
#define UPPER 300
#define STEP 20

float fahr_to_cel(float);

main()
{
	float fahr, cel;
	
	fahr = LOWER;
	while (fahr <= UPPER) {
		cel = fahr_to_cel(fahr);
		printf("%6.1f\t%6.1f\n", fahr, cel);
		fahr += STEP;
	}
}

float fahr_to_cel(float fahr)
{
	return 5 * (fahr - 32) / 9;
}
