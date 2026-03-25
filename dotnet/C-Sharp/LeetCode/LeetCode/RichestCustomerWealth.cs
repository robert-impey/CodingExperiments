namespace LeetCode;

// https://leetcode.com/problems/richest-customer-wealth/

public class RichestCustomerWealth
{
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;

        for (var i = 0; i < accounts.Length; i++)
        {
            var sum = 0;

            for (var j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if (sum > max)
            {
                max = sum;
            }
        }

        return max;
    }
}
