#!/usr/bin/env python3

max_number = int(input("How many numbers?"))

for i in range(1, max_number + 1):
    print("%d * %d = %d" % (i, i, i * i))
