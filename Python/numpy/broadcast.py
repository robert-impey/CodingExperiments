#!/usr/bin/env python3

# See https://www.coursera.org/learn/neural-networks-deep-learning/lecture/uBuTv/broadcasting-in-python

import numpy as np

a = np.array([[56.0, 0.0, 4.4, 68.0],
              [1.2, 104.0, 52.0, 8.0],
              [1.8, 135.0, 99.0, 0.9]])

cal = a.sum(axis=0)
print(cal)

percentage = 100.0 * a / cal
print(percentage)
