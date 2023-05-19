#!/usr/bin/env python3

# See https://numpy.org/devdocs/user/quickstart.html

import numpy as np

a = np.arange(15).reshape(3, 5)

print("a: ")
print(a)
print("a.shape: ", a.shape)
print("a.ndim: ", a.ndim)
print("a.dtype.name: ", a.dtype.name)
print("a.itemsize: ", a.itemsize)
print("a.size: ", a.size)
print("type(a): ", type(a))

print("b = np.array([6, 7, 8])")
b = np.array([6, 7, 8])

print("b: ", b)
print("type(b): ", type(b))
