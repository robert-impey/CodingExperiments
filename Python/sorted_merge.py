#!/usr/bin/env python3


def sorted_merge(l1, l2):
    if len(l1) == 0:
        return l2

    if len(l2) == 0:
        return l1

    merged = []

    index1 = index2 = 0
    while True:
        if index1 < len(l1) and index2 < len(l2):
            if l1[index1] <= l2[index2]:
                merged.append(l1[index1])
                index1 += 1
            else:
                merged.append(l2[index2])
                index2 += 1
        elif index1 < len(l1):
            merged.append(l1[index1])
            index1 += 1
        elif index2 < len(l2):
            merged.append(l2[index2])
            index2 += 1
        else:
            break

    return merged


def test_sorted_merge():
    tests = [
        ([], [], []),
        ([1], [1], [1, 1]),
        ([1], [2], [1, 2]),
        ([2], [1], [1, 2]),
        ([1, 3], [2], [1, 2, 3]),
        ([2], [1, 3], [1, 2, 3]),
        ([1], [], [1]),
        ([], [1], [1]),
        ([], [1, 1, 1, 1], [1, 1, 1, 1]),
    ]

    for l1, l2, expectation in tests:
        assert sorted_merge(l1, l2) == expectation
