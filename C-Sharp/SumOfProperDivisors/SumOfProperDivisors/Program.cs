using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static SumOfProperDivisors.Lib.SumOfProperDivisors;

namespace SumOfProperDivisors
{
    class Program
    {
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
