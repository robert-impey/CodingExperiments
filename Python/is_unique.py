#!/usr/bin/env python3

def is_unique(input_str):
    already_seen = dict()

    for c in input_str:
        if c not in already_seen:
            already_seen[c] = True
        else:
            return False

    return True

def is_unique_no_data_structure(input_str):
    for i, c in enumerate(input_str):
        for j in range(i):
            if input_str[j] == c:
                return False

    return True

def is_unique_rec(input_str, pivot = 0):
    if (pivot < len(input_str)):
        c = input_str[pivot]

        for i in range(pivot):
            if (input_str[i] == c):
                return False
        
        return is_unique_rec(input_str, pivot + 1)

    return True

def print_uniqueness(input_str):
    is_unique_result = is_unique(input_str)
    no_ds_result = is_unique_no_data_structure(input_str)
    rec = is_unique_rec(input_str)

    algos_match = is_unique_result == no_ds_result == rec
    print(f"'{input_str}', {is_unique_result}, {no_ds_result}, {rec}, {algos_match}")

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
