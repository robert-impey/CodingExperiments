using System;
using static System.Console;
using static SumOfProperDivisors.Lib.SumOfProperDivisors;

namespace SumOfProperDivisors
{
    class Program
    {
        /// <summary>
        /// http://www.geeksforgeeks.org/sum-of-all-proper-divisors-of-a-natural-number/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                int intArg;
                if (Int32.TryParse(arg, out intArg))
                {
                    WriteLine(String.Format("Sum of proper divisors of {0} is {1}", intArg, Calculate(intArg)));
                }
            }
        }
    }
}
