#!/usr/bin/env python3

class Node:
    def __init__(self, datum, next = None):
        self.datum = datum
        self.next = next

class SinglyLinkedList:
    def __init__(self):
        self.head = None

    def enumerate(self):
        if self.head is None:
            return []
            
        head = self.head
        while head.next is not None:
            yield head.datum
            head = head.next
        yield head.datum
        
    def add_front(self, datum):
        if self.head is None:
            self.head = Node(datum)
        else:
            next = Node(datum, self.head)
            self.head = next

def test_empty():
    empty_list = SinglyLinkedList()
    assert len(list(empty_list.enumerate())) == 0

def test_single_entry():
    sll = SinglyLinkedList()
    
    sll.add_front(1)
    
    enumerated = list(sll.enumerate())
    assert len(enumerated) == 1
    assert enumerated[0] == 1

def test_filled():
    sll = SinglyLinkedList()
    
    sll.add_front(1)
    sll.add_front(2)
    sll.add_front(3)
    
    enumerated = list(sll.enumerate())
    assert len(enumerated) == 3
    assert enumerated[0] == 3
    assert enumerated[1] == 2
    assert enumerated[2] == 1