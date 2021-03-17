using System;
using static System.Console;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(@"How many 6 digit numbers are like 225599?
That is XXYYZZ, three pairs of matching numbers where each pair does not match?");

            var totalCount = 0;
            var matchingCount = 0;
            for (var i = 0; i <= 9; i++)
            {
                for (var ii = 0; ii <= 9; ii++)
                {
                    for (var j = 0; j <= 9; j++)
                    {
                        for (var jj = 0; jj <= 9; jj++)
                        {
                            for (var k = 0; k <= 9; k++)
                            {
                                for (var kk = 0; kk <= 9; kk++)
                                {
                                    totalCount++;

                                    if (i == ii && j ==jj && k == kk && i != j && i != k && j != k)
                                    {
                                        matchingCount++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            WriteLine($"Total Count: {totalCount}");
            WriteLine($"Matching Count: {matchingCount}");
        }       
    }
}
