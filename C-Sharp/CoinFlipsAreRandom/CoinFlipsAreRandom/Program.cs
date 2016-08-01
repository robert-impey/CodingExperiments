using System;
using static System.Console;

namespace CoinFlipsAreRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"heads, tails, flips, heads ratio");

            var runs = 1000;

            var flips = 33577342;

            var randomNumberGenerator = new Random();

            for (var run = 0; run < runs; run++)
            {
                var heads = 0;

                for (var coinToss = 0; coinToss < flips; coinToss++)
                {
                    var toss = randomNumberGenerator.Next(2);

                    if (toss > 0)
                    {
                        heads++;
                    }
                }

                WriteLine($"{heads}, {flips - heads}, {flips}, {(0.0 + heads) / flips}");
            }
        }
    }
}
