#!/usr/bin/env python3

# https://numpy.org/devdocs/user/quickstart.html#indexing-slicing-and-iterating

import numpy as np

def f(x, y):
    return 10 * x + y

b = np.fromfunction(f, (5, 4), dtype=np.int_)

def main():
    #print('Building an array with a function')

    #print(b)

    print('Flat:')

    for elem in b.flat:
        print(elem)

if __name__ == '__main__':
    main()
