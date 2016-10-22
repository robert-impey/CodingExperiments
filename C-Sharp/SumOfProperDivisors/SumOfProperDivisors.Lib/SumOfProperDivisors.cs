using System;

namespace SumOfProperDivisors.Lib
{
    public static class SumOfProperDivisors
    {
        public static int Calculate(int input)
        {
            var sum = 0;

            var sqrt = Math.Pow(input, 0.5);

            for (var i = 1; i <= sqrt; i++)
            {
                if (input % i == 0)
                {
                    sum += i;
                    var other = (input / i);
                    if (i != other && other != input)
                    {
                        sum += other;
                    }
                }
            }

            return sum;
        }
    }
}
