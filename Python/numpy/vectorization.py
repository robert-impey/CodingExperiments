#!/usr/bin/env python3

import numpy as np
import time

a = np.arange(10)

print(a)

sum_of_a = 0

for an_a in a:
    sum_of_a += an_a

print(sum_of_a)

print(np.sum(a))

size = 1000000
a = np.random.rand(size)
b = np.random.rand(size)

start = time.time()
c = np.dot(a, b)
finish = time.time()

print(c)
print(f'Vectorized version: {1000 * (finish - start)} ms')

c = 0
start = time.time()

for i in range(size):
    c += a[i] * b[i]

finish = time.time()

print(c)
print(f'For loop version: {1000 * (finish - start)} ms')
