namespace LeetCode;

public class LibraryLateFeeCalculator
{
    public int LateFee(int[] daysLate)
    {
        var lateFee = 0;

        foreach (var days in daysLate)
        {
            if (days == 1)
            {
                lateFee += 1;
            }
            else if (days <= 5)
            {
                lateFee += 2 * days;
            }
            else if (days > 5)
            {
                lateFee += 3 * days;
            }
        }

        return lateFee;
    }
}
