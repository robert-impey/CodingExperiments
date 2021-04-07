#!/usr/bin/env python3


class Node:
    def __init__(self, datum, left=None, right=None):
        self.datum = datum
        self.left = left
        self.right = right


#      1
#    /   \
#   5     8
#  / \     \
# 4   3     0

four = Node(4)
three = Node(3)
zero = Node(0)
five = Node(5, four, three)
eight = Node(8, None, zero)
one = Node(1, five, eight)


def in_order_traversal(tree):
    def helper(tree, acc):
        if tree.left is not None:
            acc = helper(tree.left, acc)
        acc.append(tree.datum)
        if tree.right is not None:
            acc = helper(tree.right, acc)
        return acc

    return helper(tree, [])


def pre_order_traversal(tree):
    def helper(tree, acc):
        acc.append(tree.datum)
        if tree.left is not None:
            acc = helper(tree.left, acc)
        if tree.right is not None:
            acc = helper(tree.right, acc)
        return acc

    return helper(tree, [])


def post_order_traversal(tree):
    def helper(tree, acc):
        if tree.left is not None:
            acc = helper(tree.left, acc)
        if tree.right is not None:
            acc = helper(tree.right, acc)
        acc.append(tree.datum)
        return acc

    return helper(tree, [])


def test_in_order_traversal():
    traversed = in_order_traversal(one)
    assert traversed == [4, 5, 3, 1, 8, 0]


def test_pre_order_traversal():
    traversed = pre_order_traversal(one)
    assert traversed == [1, 5, 4, 3, 8, 0]


def test_post_order_traversal():
    traversed = post_order_traversal(one)
    assert traversed == [4, 3, 5, 0, 8, 1]
