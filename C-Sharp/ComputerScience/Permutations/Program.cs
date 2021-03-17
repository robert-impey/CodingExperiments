using static System.Console;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "count")
                {
                    if (args.Length > 0)
                    {
                        Fraction? fraction = null;
                        if (args[1] == "three-unequal-pairs")
                        {
                            fraction = new ThreeUnequalPairsPermutationCounter().Count();
                        }
                        
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
}
