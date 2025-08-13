import unittest

from doubly_linked_list_to_array import Solution, Node


class TestDoublyLinkedListToArray(unittest.TestCase):
    def test_example_1(self):
        sln = Solution()

        head = Node(1)
        previous_node = head

        next_node = Node(2, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(3, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(4, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(3, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(2, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(1, previous_node)
        previous_node.next = next_node

        self.assertEqual([1, 2, 3, 4, 3, 2, 1], sln.toArray(head))

    def test_example_2(self):
        sln = Solution()

        head = Node(2)
        previous_node = head

        next_node = Node(2, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(2, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(2, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(2, previous_node)
        previous_node.next = next_node

        self.assertEqual([2, 2, 2, 2, 2], sln.toArray(head))

    def test_example_3(self):
        sln = Solution()

        head = Node(3)
        previous_node = head

        next_node = Node(2, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(3, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(2, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(3, previous_node)
        previous_node.next = next_node
        previous_node = next_node

        next_node = Node(2, previous_node)
        previous_node.next = next_node

        self.assertEqual([3, 2, 3, 2, 3, 2], sln.toArray(head))


if __name__ == "__main__":
    unittest.main()
