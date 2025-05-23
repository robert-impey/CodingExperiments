from find_max import find_max


def test_lists():
    expectations = [([], None), ([1], 1), ([1, 5, 3, 4, 2], 5)]

    for (test_input, exp) in expectations:
        assert find_max(test_input) == exp
