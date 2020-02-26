#!/usr/bin/env python3

def count_possible_steps(n):
    if n == 0:
        return 0
    if n == 1:
        return 1
    if n == 2:
        return 2
    if n == 3:
        return 4
    return count_possible_steps(n - 1) + count_possible_steps(n - 2) + count_possible_steps(n - 3)
    
def test_count():
    tests = [
        (0, 0),
        (1, 1),
        (2, 2), # 2, 1-1
        (3, 4), # 3, 1-2, 2-1, 1-1-1
        (4, 7) # 3-1, 2-2, 2-1-1, 1-3, 1-2-1, 1-1-2, 1-1-1-1
    ]
    for (input, expectation) in tests:
        assert count_possible_steps(input) == expectation
