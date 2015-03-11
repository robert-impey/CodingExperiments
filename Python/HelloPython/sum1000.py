#!/usr/bin/env python3

sum_of_numbers = 0
max_number = 1000

for i in range(1, max_number + 1):
    print("Adding %d to %d" % (i, sum_of_numbers))
    sum_of_numbers += i

print("The sum_of_numbers: %d" % sum_of_numbers)

