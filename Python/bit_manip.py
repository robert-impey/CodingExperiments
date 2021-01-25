#!/usr/bin/env python3

from bytes import get_bytes


def make_one(bits, bit):
    got_bytes = get_bytes(bits)
    
    got_bytes[-bit - 1] = ord("1")
    
    return got_bytes.decode("utf-8")


def test_make_one():
    tests = [
        ("0", 0, "1"),
        ("0000", 0, "0001"),
        ("0000", 1, "0010"),
        ("0000", 2, "0100"),
        ("0000", 3, "1000")
    ]
    
    for bits, bit, expectation in tests:
        assert make_one(bits, bit) == expectation
