def is_unique(input_str):
    already_seen = dict()

    for c in input_str:
        if c not in already_seen:
            already_seen[c] = True
        else:
            return False

    return True

def print_uniqueness(input_str):
    print(f"'{input_str}': {is_unique(input_str)}")

print_uniqueness("")
print_uniqueness("a")
print_uniqueness("ab")
print_uniqueness("aa")
print_uniqueness("aba")
print_uniqueness("abcde")
print_uniqueness("abcdea")
print_uniqueness("abcdec")
print_uniqueness("你好")
print_uniqueness("好不好")
