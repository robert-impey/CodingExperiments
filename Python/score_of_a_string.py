# https://leetcode.com/problems/score-of-a-string/


class Solution(object):
    def scoreOfString(self, s):
        score = 0

        prev = s[0]

        for c in s[1:]:
            prev_char = ord(prev)
            curr_char = ord(c)

            score += abs(prev_char - curr_char)
            prev = c

        return score
