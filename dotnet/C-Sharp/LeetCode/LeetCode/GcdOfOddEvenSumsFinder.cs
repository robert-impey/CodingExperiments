namespace LeetCode;

// https://leetcode.com/problems/gcd-of-odd-and-even-sums

public class GcdOfOddEvenSumsFinder
{
    public int GcdOfOddEvenSums(int n)
    {
        const int addend = 2;

        var odd = 1;
        var even = 2;
        var oddSum = odd;
        var evenSum = even;
        for (var i = 2; i <= n; i++)
        {
            odd += addend;
            even += addend;

            oddSum += odd;
            evenSum += even;
        }

        return Gcd(oddSum, evenSum);
    }

    private int Gcd(int a, int b)
    {
        var larger = a;
        var smaller = b;

        if (b > a)
        {
            larger = b;
            smaller = a;
        }

        if (smaller == 0)
        {
            return larger;
        }

        return Gcd(larger - smaller, smaller);
    }
}
