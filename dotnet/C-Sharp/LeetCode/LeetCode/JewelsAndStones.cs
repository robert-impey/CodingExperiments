namespace LeetCode;

// https://leetcode.com/problems/jewels-and-stones/description/

public class JewelsAndStones
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var count = 0;

        var jewelsSet = new HashSet<char>();

        foreach (var j in jewels)
        {
            jewelsSet.Add(j);
        }

        foreach (var s in stones)
        {
            if (jewelsSet.Contains(s))
            {
                count++;
            }
        }

        return count;
    }
}
