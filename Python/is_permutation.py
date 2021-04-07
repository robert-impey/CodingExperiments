#!/usr/bin/env python3


def sort_string(string):
    return "".join(sorted(string))


def is_permutation(a, b):
    if len(a) != len(b):
        return False

    return sort_string(a) == sort_string(b)


def test_permutations():
    tests = [
        ("a", "a", True),
        ("a", "a", True),
        ("aa", "aa", True),
        ("ab", "ab", True),
        ("ab", "ba", True),
        ("a", "b", False),
        ("a", "aa", False),
        ("ab", "ac", False),
    ]

    for (a, b, expectation) in tests:
        assert is_permutation(a, b) == expectation
