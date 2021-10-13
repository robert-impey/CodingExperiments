using Graphs;
using System;

namespace AdjacencyListToDot
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var fileName = args[0];

                var graph = FileReader.ReadAdjacencyList(fileName);

                DotPrinter.Print(graph);
            }
            else
            {
                Console.WriteLine("Please give me just one file!");
            }
        }
    }
}
