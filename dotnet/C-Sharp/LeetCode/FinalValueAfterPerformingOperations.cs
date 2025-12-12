namespace LeetCode;

// https://leetcode.com/problems/final-value-of-variable-after-performing-operations

public class FinalValueAfterPerformingOperations
{
    public int FinalValueAfterOperations(string[] operations)
    {
        var x = 0;

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "++X":
                case "X++":
                    x++;
                    break;
                case "--X":
                case "X--":
                    x--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        return x;
    }
}
