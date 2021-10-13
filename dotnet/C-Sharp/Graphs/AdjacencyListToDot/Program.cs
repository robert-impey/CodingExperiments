using Graphs;
using System;
using System.IO;

namespace AdjacencyListToDot
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var fileName = args[0];

                var graph = new Graph();

                graph.ReadFile(fileName);

                graph.PrintDot();
            }
            else
            {
                Console.WriteLine("Please give me just one file!");
            }
        }
    }
}
