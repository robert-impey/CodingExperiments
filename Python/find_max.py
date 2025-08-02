#!/usr/bin/env python3


def find_max(the_list: list[float]) -> float | None:
    if len(the_list) == 0:
        return

    max_found = the_list[0]

    for i in range(1, len(the_list)):
        if the_list[i] > max_found:
            max_found = the_list[i]

    return max_found


if __name__ == "__main__":
    my_list = [1.0, 2, 3, 2]

    print(find_max(my_list))
