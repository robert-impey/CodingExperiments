#!/usr/bin/env python3

from sys import argv
from random import shuffle
import time

class Stopwatch:
    def __init__(self):
        self.start_time = None
        self.end_time = None

    def start(self):
        if (self.start_time != None):
            raise Exception("Stopwatch already started!")

        self.start_time = time.clock()

    def stop(self):
        if (self.start_time == None):
            raise Exception("Stopwatch not started!")

        self.end_time = time.clock()

    def reset(self):
        self.start_time= None
        self.end_time = None
        self.start()

    def report(self, task):
        self.stop()
        print("Time to %s: %f seconds" % (task, (self.end_time - self.start_time)))

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
    max = 10000
    should_print = max <= 20
    if len(argv) == 2:
        max = argv[1]

    numbers = list(range(max))

    shuffle(numbers)
    
    if should_print:
        print("The numbers: ")
        for n in numbers:
            print(n, end=' ')
        print()

    stopwatch = Stopwatch()

    stopwatch.start()
    get_max_priority_queue = GetMaxPriorityQueue()
    stopwatch.report("initialize the get_max_priority_queue")

    stopwatch.reset()
    for n in numbers:
        get_max_priority_queue.enqueue(n)
    stopwatch.report("enqueue members")

    stopwatch.reset()
    print('get_max_priority_queue.count(): ', get_max_priority_queue.count())
    stopwatch.report("count members when full")

    stopwatch.reset()
    while (True):
        m = get_max_priority_queue.dequeue()
        if m == None:
            break
        if should_print:
            print(m, end=' ')

    if should_print:
        print()
    stopwatch.report("dequeue members")

    stopwatch.reset()
    print('get_max_priority_queue.count(): ', get_max_priority_queue.count())
    stopwatch.report("count members when empty")
