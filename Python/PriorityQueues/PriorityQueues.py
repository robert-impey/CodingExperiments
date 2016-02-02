#!/usr/bin/env python3

from sys import argv
from random import shuffle

class GetMaxPriorityQueue:
    def __init__(self):
        self.members = []

    def enqueue(self, new_member):
        self.members.append(new_member)

    def dequeue(self):
        if len(self.members) == 0:
            return None

        current_max = self.members[0]
        for i in range(1, len(self.members)):
            if (current_max < self.members[i]):
                current_max = self.members[i]

        i = 0
        while (True):
            if (self.members[i] == current_max):
                del(self.members[i])
                break
            i += 1
        
        return current_max
    
    def count(self):
        return len(self.members)

if __name__ == '__main__':
    max = 10
    if len(argv) == 2:
        max = argv[1]

    numbers = list(range(max))

    shuffle(numbers)
    
    print("The numbers: ")
    for n in numbers:
        print(n, end=' ')
    print()

    get_max_priority_queue = GetMaxPriorityQueue()

    for n in numbers:
        get_max_priority_queue.enqueue(n)

    print('get_max_priority_queue.count(): ', get_max_priority_queue.count())

    while (True):
        m = get_max_priority_queue.dequeue()
        if m == None:
            break
        print(m, end=' ')
    print()

    print('get_max_priority_queue.count(): ', get_max_priority_queue.count())
