namespace LeetCode;

// https://leetcode.com/problems/minimum-moves-to-equal-array-elements-iii/

public class MinMovesFinder
{
    public int MinMoves(int[] nums)
    {
        if (nums.Length < 2)
        {
            return 0;
        }

        // Find Max
        var max = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }

        // Sum the diff from max
        var sum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = max - nums[i];
            sum += diff;
        }

        return sum;
    }
}
