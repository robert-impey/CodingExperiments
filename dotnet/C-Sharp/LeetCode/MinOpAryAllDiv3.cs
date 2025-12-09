namespace LeetCode;

// https://leetcode.com/problems/find-minimum-operations-to-make-all-elements-divisible-by-three

public class MinOpAryAllDiv3
{
    public int MinimumOperations(int[] nums) => nums.Sum(x => x % 3 == 0 ? 0 : 1);
}
