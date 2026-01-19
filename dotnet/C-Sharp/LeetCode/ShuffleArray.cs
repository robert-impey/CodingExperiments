namespace LeetCode;

// https://leetcode.com/problems/shuffle-the-array/

public class ShuffleArray
{
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[nums.Length];

        for (var i = 0; i < n; i++)
        {
            var j = 2 * i;
            result[j] = nums[i];
            result[j + 1] = nums[i + n];
        }

        return result;
    }
}
