namespace LeetCode;

// https://leetcode.com/problems/minimum-operations-to-make-array-sum-divisible-by-k

public class MinOpArySumDivK
{
    public int MinOperations(int[] nums, int k) => nums.Sum() % k;
}
