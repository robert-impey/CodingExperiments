namespace LeetCode;

public static class IntegerExtensions
{
    public static int[] ToDigits(this int num, int numberOfDigits)
    {
        var digits = new int[numberOfDigits];

        int finalIndex = numberOfDigits - 1;

        for (int i = 0; i < numberOfDigits; i++)
        {
            int rem = num % 10;
            digits[finalIndex - i] = rem;

            if (num < 10)
            {
                break;
            }

            num /= 10;
        }

        return digits;
    }
}
