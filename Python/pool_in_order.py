#!/usr/bin/env python3

# See https://docs.python.org/3/library/multiprocessing.html

from multiprocessing import Pool


def f(x):
    return x*x


def in_order(xs):
    if len(xs) > 1:
        previous = xs[0]

        for x in xs[1:]:
            if x < previous:
                return False
            previous = x

    return True


if __name__ == '__main__':
    with Pool(5) as p:
        squares = p.map(f, range(1000))
        print(in_order(squares))
