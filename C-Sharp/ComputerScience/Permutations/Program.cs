using static System.Console;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var fraction = new ThreeUnequalPairsPermutationCounter().Count();

            WriteLine($"Matching Count: {fraction.Matching}");
            WriteLine($"Total Count: {fraction.Total}");
        }       
    }
}
