#!/usr/bin/env python3

def sorted_merge(l1, l2):
    return []
    
def test_sorted_merge():
    tests = [
        ([], [], []),
        ([1], [1], [1, 1]),
        ([1], [2], [1, 2]),
        ([2], [1], [1, 2]),
        ([1, 3], [2], [1, 2, 3])
    ]
    
    for l1, l2, expectation in tests:
        assert sorted_merge(l1, l2) == expectation
