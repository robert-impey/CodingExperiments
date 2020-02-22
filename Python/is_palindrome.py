#!/usr/bin/env python3

def is_palindrome(string):
    return True

def test_palindromes():
    tests = [
        ("", True),
        ("a", True),
        ("aa", True),
        ("aba", True),
        ("abba", True),
        
        ("ab", False),
        ("abab", False)
    ]
    
    for (input, expectation) in tests:
        assert is_palindrome(input) == expectation
