# Bytes module


def get_bytes(in_string: str) -> bytearray:
    ba = bytearray()
    ba.extend(map(ord, in_string))
    return ba
