#!/usr/bin/env python3


class Node[T]:
    def __init__(
        self,
        datum: T,
        left: Node[T] | None = None,
        right: Node[T] | None = None,
    ) -> None:
        self.datum: T = datum
        self.left: Node[T] | None = left
        self.right: Node[T] | None = right


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


def in_order_traversal[T](tree: Node[T]) -> list[T]:
    def helper(tree: Node[T], acc: list[T]) -> list[T]:
        if tree.left is not None:
            acc = helper(tree.left, acc)
        acc.append(tree.datum)
        if tree.right is not None:
            acc = helper(tree.right, acc)
        return acc

    return helper(tree, [])


def pre_order_traversal[T](tree: Node[T]) -> list[T]:
    def helper(tree: Node[T], acc: list[T]) -> list[T]:
        acc.append(tree.datum)
        if tree.left is not None:
            acc = helper(tree.left, acc)
        if tree.right is not None:
            acc = helper(tree.right, acc)
        return acc

    return helper(tree, [])


def post_order_traversal[T](tree: Node[T]) -> list[T]:
    def helper(tree: Node[T], acc: list[T]) -> list[T]:
        if tree.left is not None:
            acc = helper(tree.left, acc)
        if tree.right is not None:
            acc = helper(tree.right, acc)
        acc.append(tree.datum)
        return acc

    return helper(tree, [])


def test_in_order_traversal() -> None:
    traversed = in_order_traversal(one)
    assert traversed == [4, 5, 3, 1, 8, 0]


def test_pre_order_traversal() -> None:
    traversed = pre_order_traversal(one)
    assert traversed == [1, 5, 4, 3, 8, 0]


def test_post_order_traversal() -> None:
    traversed = post_order_traversal(one)
    assert traversed == [4, 3, 5, 0, 8, 1]
