#!/usr/bin/env python3

import time
from sys import argv
from random import shuffle
from heapq import heappush, heappop


class Stopwatch:
    def __init__(self):
        self.start_time = None
        self.end_time = None

    def start(self):
        if self.start_time is not None:
            raise Exception("Stopwatch already started!")

        self.start_time = time.perf_counter_ns()

    def stop(self):
        if self.start_time is None:
            raise Exception("Stopwatch not started!")

        self.end_time = time.perf_counter_ns()

    def reset(self):
        self.start_time = None
        self.end_time = None
        self.start()

    def report(self, task):
        self.stop()
        print("Time to %s: %f ns" % (task, (self.end_time - self.start_time)))


class PriorityQueue:
    def __init__(self):
        self.members = []

    def count(self):
        return len(self.members)


class GetMinPriorityQueue(PriorityQueue):
    def enqueue(self, new_member):
        self.members.append(new_member)

    def dequeue(self):
        if len(self.members) == 0:
            return None

        current_min = self.members[0]
        for i in range(1, len(self.members)):
            if current_min > self.members[i]:
                current_min = self.members[i]

        i = 0
        while True:
            if self.members[i] == current_min:
                del (self.members[i])
                break
            i += 1

        return current_min


class InsertInOrderPriorityQueue(PriorityQueue):
    def enqueue(self, new_member):
        if len(self.members) == 0:
            self.members.append(new_member)
        else:
            i = len(self.members)
            while i >= 0:
                i -= 1
                if self.members[i] > new_member:
                    self.members.insert(i + 1, new_member)
                    break

            if i == -1:
                self.members.insert(0, new_member)

    def dequeue(self):
        if len(self.members) == 0:
            return None

        return self.members.pop()


class HeapqPriorityQueue(PriorityQueue):
    def enqueue(self, new_member):
        heappush(self.members, new_member)

    def dequeue(self):
        if len(self.members) == 0:
            return None

        return heappop(self.members)


if __name__ == '__main__':
    size = 10000
    if len(argv) > 1:
        size = int(argv[1])

    algo = 'GetMin'
    if len(argv) > 2:
        algo = argv[2]

    print("Enqueuing and dequeuing {0} integers using a {1} priority queue.".format(size, algo))

    should_print = size <= 20
    numbers = list(range(size))

    shuffle(numbers)

    if should_print:
        print("The numbers: ")
        for n in numbers:
            print(n, end=' ')
        print()

    stopwatch = Stopwatch()

    stopwatch.start()
    if algo == 'GetMin':
        priority_queue = GetMinPriorityQueue()
    elif algo == 'InsertInOrder':
        priority_queue = InsertInOrderPriorityQueue()
    elif algo == 'Heapq':
        priority_queue = HeapqPriorityQueue()
    else:
        raise Exception("Unrecognised algo: {0}".format(algo))

    stopwatch.report("initialize the priority_queue")

    stopwatch.reset()
    for n in numbers:
        priority_queue.enqueue(n)
    stopwatch.report("enqueue members")

    stopwatch.reset()
    print('priority_queue.count(): ', priority_queue.count())
    stopwatch.report("count members when full")

    stopwatch.reset()
    while True:
        m = priority_queue.dequeue()
        if m is None:
            break
        if should_print:
            print(m, end=' ')

    if should_print:
        print()
    stopwatch.report("dequeue members")

    stopwatch.reset()
    print('priority_queue.count(): ', priority_queue.count())
    stopwatch.report("count members when empty")
