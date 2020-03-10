#!/usr/bin/env python3

from bytes import get_bytes

foo_bytes = get_bytes("foo")

print(foo_bytes)

print(foo_bytes.decode("utf-8"))

g_bytes = get_bytes("g")

foo_bytes[2] = g_bytes[0]

print(foo_bytes.decode("utf-8"))
