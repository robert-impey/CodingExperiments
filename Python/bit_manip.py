#!/usr/bin/env python3

def get_bytes(in_string):
    ba = bytearray()
    ba.extend(map(ord, in_string))
    return ba
    
def make_one(bits, bit):
    bytes = get_bytes(bits)
    
    bytes[-bit-1] = ord("1")
    
    return bytes.decode("utf-8")

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
