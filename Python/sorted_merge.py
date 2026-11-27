#!/usr/bin/env python3

from collections.abc import Sequence
from typing import Protocol, Self


class SupportsLe(Protocol):
    """Protocol for types supporting <= comparison."""

    def __le__(self, other: Self, /) -> bool: ...


def sorted_merge[T: SupportsLe](l1: Sequence[T], l2: Sequence[T]) -> list[T]:
    if len(l1) == 0:
        return list(l2)

    if len(l2) == 0:
        return list(l1)

    merged: list[T] = []

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


def test_sorted_merge() -> None:
    tests: list[tuple[list[int], list[int], list[int]]] = [
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
