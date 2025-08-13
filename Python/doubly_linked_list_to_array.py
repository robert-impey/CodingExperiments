# See https://leetcode.com/problems/convert-doubly-linked-list-to-array-i/

# Definition for a Node.
class Node:
    def __init__(self, val, prev=None, next=None):
        self.val = val
        self.prev = prev
        self.next = next


from typing import List, Optional


class Solution:
    def toArray(self, root: 'Optional[Node]') -> List[int]:
        answer = []

        current = root
        while True:
            if current:
                answer.append(current.val)

            next_node = current.next

            if next_node is None:
                return answer

            current = next_node
