#!/usr/bin/env python3

# https://numpy.org/doc/stable/user/quickstart.html#basic-operations

import numpy as np

a = np.array([20, 30, 40, 50])
b = np.arange(4)

c = a - b

def main():
    print(b)
    print(c)

    print(b ** 2)
    print(10 * np.sin(a))

    print(a < 35)

if __name__ == '__main__':
    main()