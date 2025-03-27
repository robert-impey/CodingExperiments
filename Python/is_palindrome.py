#!/usr/bin/env python3


def is_palindrome(string: str) -> bool:
    for i in range(int(len(string) / 2)):
        if string[i] != string[len(string) - (1 + i)]:
            return False

    return True


def test_palindromes():
    tests = [
        ("", True),
        ("a", True),
        ("aa", True),
        ("aba", True),
        ("abba", True),
        ("ab", False),
        ("abab", False),
    ]

    for (test_input, expectation) in tests:
        assert is_palindrome(test_input) == expectation
