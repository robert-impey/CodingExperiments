namespace LeetCode;

public class SneakyNumbers
{
    private const int MaxValue = 100;
    private const int MaxSneaky = 2;

    public int[] GetSneakyNumbers(int[] nums)
    {
        var sneaky = new int[MaxSneaky];

        var foundDuplicates = 0;

        var seen = new int[MaxValue];

        foreach (var num in nums)
        {
            seen[num]++;
            if (seen[num] == 2)
            {
                sneaky[foundDuplicates] = num;
                foundDuplicates++;
                if (foundDuplicates == MaxSneaky)
                {
                    break;
                }
            }
        }

        return sneaky;
    }
}
