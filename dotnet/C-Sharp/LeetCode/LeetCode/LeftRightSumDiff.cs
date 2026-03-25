namespace LeetCode;

// https://leetcode.com/problems/left-and-right-sum-differences/

public class LeftRightSumDiff
{
    public int[] LeftRightDifference(int[] nums)
    {
        var leftSum = new int[nums.Length];
        var rightSum = new int[nums.Length];
        var answer = new int[nums.Length];

        var sum = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            sum += nums[i - 1];

            leftSum[i] = sum;
        }

        var total = sum + nums[nums.Length - 1];
        sum = total;

        for (var i = rightSum.Length - 2; i >= 0; i--)
        {
            sum -= nums[i + 1];

            rightSum[i] = total - sum;
        }

        for (var i = 0; i < answer.Length; i++)
        {
            var diff = leftSum[i] - rightSum[i];

            if (diff >= 0)
            {
                answer[i] = diff;
            }
            else
            {
                answer[i] = -1 * diff;
            }
        }

        return answer;
    }
}
