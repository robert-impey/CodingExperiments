#!/usr/bin/env python3

# https://numpy.org/doc/stable/user/quickstart.html#array-creation

import numpy as np
from numpy import pi
import matplotlib.pyplot as pp

a = np.array([2, 3, 4])
zs = np.zeros((3, 4))
ones = np.ones((2, 3, 4), dtype=np.int16)
empties = np.empty((2, 3))
ara = np.arange(10, 30, 5)
x0s = np.linspace(0, 2, 9)
x1s = np.linspace(0, 2 * pi, 100)
fs = np.sin(x1s)

def main():
    print(fs)

if __name__ == '__main__':
    main()
