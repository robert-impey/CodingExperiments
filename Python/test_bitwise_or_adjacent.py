import unittest

from bitwise_or_adjacent import Solution


class TestBitwiseOrAdjacent(unittest.TestCase):
    def test_example_1(self):
        sln = Solution()
        self.assertEqual(sln.orArray([1, 3, 7, 15]), [3, 7, 15])

    def test_example_2(self):
        sln = Solution()
        self.assertEqual(sln.orArray([8, 4, 2]), [12, 6])

    def test_example_3(self):
        sln = Solution()
        self.assertEqual(sln.orArray([5, 4, 9, 11]), [5, 13, 11])


if __name__ == "__main__":
    unittest.main()
