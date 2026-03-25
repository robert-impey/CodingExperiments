namespace LeetCode;

// https://leetcode.com/problems/transform-array-by-parity/

public class TransformArrayByParity
{
    public int[] TransformArray(int[] nums)
    {
        var result = new int[nums.Length];

        var countOdd = 0;

        foreach (var num in nums)
        {
            countOdd += num % 2;
        }

        for (var i = nums.Length - countOdd; i < nums.Length; i++)
        {
            result[i] = 1;
        }

        return result;
    }
}
