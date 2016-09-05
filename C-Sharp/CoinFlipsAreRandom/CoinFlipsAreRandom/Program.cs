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

            // Taken from http://www.bbc.co.uk/news/politics/eu_referendum/results
            var flips = 33551983;

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
