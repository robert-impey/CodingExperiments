
def get_bytes(in_string):
    ba = bytearray()
    ba.extend(map(ord, in_string))
    return ba

foo_bytes = get_bytes("foo")

print(foo_bytes)

print(foo_bytes.decode("utf-8"))

g_bytes = get_bytes("g")

foo_bytes[2] = g_bytes[0]

print(foo_bytes.decode("utf-8"))
