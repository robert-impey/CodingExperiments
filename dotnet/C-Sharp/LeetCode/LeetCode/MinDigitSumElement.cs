namespace LeetCode;

public class MinDigitSumElement
{
    public int MinElement(int[] nums)
    {
        var min = 46;

        foreach (var num in nums)
        {
            var digits = num.ToDigits(5);

            var sum = digits.Sum();

            if (sum < min)
            {
                min = sum;
            }
        }
        
        return min;
    }
}
