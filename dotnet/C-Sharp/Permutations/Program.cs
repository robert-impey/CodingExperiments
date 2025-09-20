using static System.Console;

namespace Permutations;

internal static class Program
{
    private static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            if (args[0] == "count")
            {
                if (args.Length > 1)
                {
                    Fraction? fraction = args[1] switch
                    {
                        "three-pairs" => new ThreePairsPermutationCounter().Count(),
                        "three-unequal-pairs" => new ThreeUnequalPairsPermutationCounter().Count(),
                        "three-ascending-pairs" => new ThreeAscendingPairsPermutationCounter().Count(),
                        "three-strictly-ascending-pairs" =>
                            new ThreeStrictlyAscendingPairsPermutationsCounter().Count(),
                        _ => null
                    };

                    if (fraction.HasValue)
                    {
                        WriteLine($"Matching Count: {fraction.Value.Matching}");
                        WriteLine($"Total Count: {fraction.Value.Total}");
                    }
                    else
                    {
                        WriteLine("Unrecognised thing to count!");
                    }
                }
                else
                {
                    WriteLine("What do you want me to count?");
                }
            }
            else
            {
                WriteLine("Unrecognised action!");
            }
        }
        else
        {
            WriteLine("Tell me what to do!");
        }
    }       
}