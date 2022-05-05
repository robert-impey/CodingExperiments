#!/usr/bin/env python3


def find_max(l):
    if len(l) == 0:
        return

    max = l[0]

    for i in range(1, len(l)):
        if l[i] > max:
            max = l[i]

    return max
