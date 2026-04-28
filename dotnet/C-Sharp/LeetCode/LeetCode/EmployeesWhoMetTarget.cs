namespace LeetCode;

public class EmployeesWhoMetTarget
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        var count = 0;

        foreach (var hour in hours)
        {
            if (hour >= target)
            {
                count++;
            }
        }

        return count;
    }
}
