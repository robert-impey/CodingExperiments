#!/usr/bin/env python3

import sys

sets = int(sys.argv[1])
total = 0

current_set: int
for current_set in range(1, sets + 1):
    print("Current set:", current_set)
    
    if current_set <= sets / 2:
        exponent = current_set - 1
    else:
        exponent = sets - current_set

    lengths = pow(2, exponent)
    print("Lengths in set:", lengths)

    total += lengths
    
print("Total lengths:", total)

