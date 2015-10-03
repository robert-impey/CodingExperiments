using BalanceParentheses.Lib;
using System;

namespace BalanceParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var stringToCheck = args[0];

                Console.WriteLine(
                    BalanceChecker.IsStringBalanced(stringToCheck)
                    ? "Balanced" : "Unbalanced");
            }
            else
            {
                Console.WriteLine("Give me a string to check!");
            }
        }
    }
}
