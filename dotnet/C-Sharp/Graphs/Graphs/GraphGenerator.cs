using System;

namespace Graphs
{
    public static class GraphGenerator
    {
        public static Graph Generate(int size, double threshold)
        {
            var graph = new Graph();

            var rand = new Random();

            for (int i = 0; i < size; i++)
            {
                var vertex = new Vertex($"{i}");

                for (int j = 0; j < size; j++)
                {
                    if (i == j  || rand.NextDouble() > threshold) continue;

                    vertex.AddNeighbour(new Vertex($"{j}"));
                }

                graph.AddVertex(vertex);
            }

            return graph;
        }
    }
}
