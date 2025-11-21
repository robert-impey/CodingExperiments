#!/usr/bin/env python3

from bytes import get_bytes


def modify_bytearray(ba: bytearray) -> None:
    g_bytes = get_bytes("g")
    ba[0] = g_bytes[0]
    print(f"In method - {foo_bytes.decode('utf-8')}")


foo_bytes = get_bytes("foo")

print(f"In main scope - {foo_bytes.decode('utf-8')}")

modify_bytearray(foo_bytes)

print(f"In main scope - {foo_bytes.decode('utf-8')}")
