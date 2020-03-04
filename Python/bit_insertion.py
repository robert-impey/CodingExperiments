#!/usr/bin/env python3

def get_bytes(str):
    str_bytes = bytearray()
    str_bytes.extend(map(ord, str))
    return str_bytes

def insert(n, m, i, j):
    n_bytes = get_bytes(n)
    m_bytes = get_bytes(m)
    
    n_bytes.reverse()
    m_bytes.reverse()
    
    for index in range(i, j + 1):
        n_bytes[index] = m_bytes[index - i]

    n_bytes.reverse()
    
    return n_bytes.decode("utf-8")
    
def test_insert():
    tests = [
        ("10000000000", "10011", 2, 6, "10001001100")
    ]
    
    for n, m, i, j, expectation in tests:
        assert insert(n, m, i, j) == expectation
