namespace LeetCode;

// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/

public class KidsWithGreatestCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = 0;

        foreach (var kid in candies)
        {
            if (kid > max)
            {
                max = kid;
            }
        }

        var result = new bool[candies.Length];

        for (var i = 0; i < candies.Length; i++)
        {
            result[i] = candies[i] + extraCandies >= max;
        }

        return result;
    }
}
