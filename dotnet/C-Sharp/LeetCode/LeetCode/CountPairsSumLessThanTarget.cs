namespace LeetCode;

// https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/

public class CountPairsSumLessThanTarget
{
    public int CountPairs(IList<int> nums, int target)
    {
        var count = 0;
        var n = nums.Count();

        for (var i = 0; i < n - 1; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (nums[i] + nums[j] < target)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
