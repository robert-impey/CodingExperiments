﻿using System;

namespace Graphs
{
    public static class DotPrinter
    {
        public static void Print(Graph graph)
        {
            Console.WriteLine("graph {");

            foreach (var vertex in graph.Vertices)
            {
                Print(vertex);
            }

            Console.WriteLine("}");
        }

        private static void Print(Vertex vertex)
        {
            foreach (var neighbour in vertex.Neighbours)
            {
                Console.WriteLine($"\t{vertex.Value} -- {neighbour.Value}");
            }
        }
    }
}
