namespace LeetCode;

// https://leetcode.com/problems/reverse-string-prefix

public class PrefixReverser
{
    public string ReversePrefix(string s, int k)
    {
        if (k == 1)
        {
            return s;
        }

        var result = new char[s.Length];

        var r = 0;
        for (var i = k - 1; i >= 0; i--)
        {
            result[r] = s[i];
            r++;
        }

        for (var i = k; i < s.Length; i++)
        {
            result[r] = s[i];
            r++;
        }

        // The following line fixes CS8603 by converting the char array to a string.
        return new string(result);
    }
}
