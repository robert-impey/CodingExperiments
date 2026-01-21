# Using CoPilot

from itertools import combinations

def powerset_indices(lst):
    n = len(lst)
    for r in range(n + 1):
        for combo in combinations(range(n), r):
            yield combo

uniq = ['a', 'b', 'c', 'd']
dupes = ['a', 'b', 'c', 'a']

indices_from_uniq = powerset_indices(uniq)
indices_from_dupes = powerset_indices(dupes)

def print_set(lst, indices):
    for idx in indices:
        for i in idx:
            print(lst[i], end="")
        print()

def main():
    print_set(uniq, indices_from_uniq)
    print_set(dupes, indices_from_dupes)

if __name__ == '__main__':
    main()
