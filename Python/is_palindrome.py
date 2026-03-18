#!/usr/bin/env python3

import unittest


def is_palindrome(string: str) -> bool:
    return string == string[::-1]


class TestPalindrome(unittest.TestCase):
    def test_palindromes(self):
        tests = [
            ("", True),
            ("a", True),
            ("aa", True),
            ("aba", True),
            ("abba", True),
            ("ab", False),
            ("abab", False),
        ]

        for test_input, expectation in tests:
            with self.subTest(test_input=test_input):
                self.assertEqual(is_palindrome(test_input), expectation)


if __name__ == "__main__":
    unittest.main()
