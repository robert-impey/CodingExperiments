using Graphs;
using System;

namespace GenerateAdjacencyList
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please give me a size and threshold!");
                return;
            }

            int size;
            if (!int.TryParse(args[0], out size))
            {
                Console.WriteLine($"Can't parse {args[0]}");
                return;
            }

            double threshold;
            if (!double.TryParse(args[1], out threshold))
            {
                Console.WriteLine($"Can't parse {args[1]}");
                return;
            }

            var graph = GraphGenerator.Generate(size, threshold);
            DotPrinter.PrintOneWay(graph);
        }
    }
}
