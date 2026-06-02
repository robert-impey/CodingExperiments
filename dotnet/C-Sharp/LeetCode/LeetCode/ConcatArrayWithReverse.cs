namespace LeetCode;

// https://leetcode.com/problems/concatenate-array-with-reverse/

public class ConcatArrayWithReverse
{
    public int[] ConcatWithReverse(int[] nums)
    {
        var concat = new int[nums.Length * 2];
        var concatLast = concat.Length - 1;

        for (var i = 0; i < nums.Length; i++)
        {
            concat[i] = nums[i];
            concat[concatLast - i] = nums[i];
        }

        return concat;
    }
}
