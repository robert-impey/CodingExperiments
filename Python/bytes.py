# Bytes module

def get_bytes(in_string):
    ba = bytearray()
    ba.extend(map(ord, in_string))
    return ba

