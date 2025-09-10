import unittest

from score_of_a_string import Solution

class TestScoreOfAString(unittest.TestCase):
    def test_example(self):
        s = 'hello'
        sln = Solution()
        self.assertEqual(sln.scoreOfString(s), 13)  # add assertion here


if __name__ == '__main__':
    unittest.main()
