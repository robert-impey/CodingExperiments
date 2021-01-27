#!/usr/bin/env python3

import numpy as np

a = np.arange(10)

print(a)

sum_of_a = 0

for an_a in a:
    sum_of_a += an_a

print(sum_of_a)

print(np.sum(a))
