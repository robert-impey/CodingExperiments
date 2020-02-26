#!/usr/bin/env python3

def count_possible_steps(n):
    def helper(n, memo):
        if memo[n] is None:
            memo[n] = count_possible_steps(n - 1) + count_possible_steps(n - 2) + count_possible_steps(n - 3)
        return memo[n]
    
    memo = []
    
    for i in range(max(4, n + 1)):
        memo.append(None)
    
    memo[0] = 0
    memo[1] = 1
    memo[2] = 2
    memo[3] = 4
    
    return helper(n, memo)
    
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
