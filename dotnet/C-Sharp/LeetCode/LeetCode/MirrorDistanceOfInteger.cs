// https://leetcode.com/problems/mirror-distance-of-an-integer/

namespace LeetCode;

public class MirrorDistanceOfInteger
{
    public int MirrorDistance(int n)
    {
        var diff = n - Reverse(n);

        if (diff >= 0)
        {
            return diff;
        }

        return -1 * diff;
    }

    public static int Reverse(int n)
    {
        var reverse = 0;

        var exp = 1_000_000_000;
        var revExp = 1;
        var inNumber = false;

        while (exp >= 1)
        {
            var addend = 0;

            if (n >= exp)
            {
                if (!inNumber)
                {
                    inNumber = true;
                }

                var div = n / exp;
                addend = div * revExp;
            }

            if (inNumber)
            {
                n %= exp;
                revExp *= 10;
            }

            reverse += addend;
            exp /= 10;
        }

        return reverse;
    }
}
