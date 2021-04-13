#!/usr/bin/env python3

# See https://numpy.org/devdocs/user/quickstart.html

import numpy as np

rg = np.random.default_rng(1)

a = np.floor(10 * rg.random((3, 4)))

print(a)
print(a.shape)
print(a.ravel())
print(a.T)
print(a.T.shape)

a.resize(6, 2)

print(a)

a = a.reshape(3, -1)
print(a)
