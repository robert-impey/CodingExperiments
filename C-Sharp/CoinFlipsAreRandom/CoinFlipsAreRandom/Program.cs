using System;
using CommandLine;
using static System.Console;

namespace CoinFlipsAreRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandLineArgs = new Options();
            if (Parser.Default.ParseArguments(args, commandLineArgs))
            {
                WriteLine("heads, tails, flips, heads share");

                var runs = commandLineArgs.Runs;
                var flips = commandLineArgs.CompetitionSize;

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
            else
            {
                WriteLine("Unable to parse the command line arguments!");
            }
        }
    }

    class Options
    {
        // Taken from http://www.bbc.co.uk/news/politics/eu_referendum/results
        [Option('s', "competitionSize", DefaultValue = 33551983, HelpText = "The size of each coin tossing competition.")]
        public int CompetitionSize { get; set; }

        [Option('r', "runs", DefaultValue = 1000, HelpText = "The number of runs of the competition")]
        public int Runs { get; set; }
    }
}
