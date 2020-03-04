#!/usr/bin/env python3

def insert(n, m, i, j):
    return n
    
def test_insert():
    tests = [
        ("10000000000", "10011", 2, 6, "10001001100")
    ]
    
    for n, m, i, j, expectation in tests:
        assert insert(n, m, i, j) == expectation
