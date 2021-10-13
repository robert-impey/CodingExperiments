using System;
using System.IO;

namespace Graphs
{
    public static class FileReader
    {
        public static Graph ReadAdjacencyList(string fileName)
        {
            var graph = new Graph();

            foreach (var line in File.ReadAllLines(fileName))
            {
                var vertices = line.Split(',');

                if (vertices.Length < 2)
                {
                    throw new Exception($"{line} does not have at least 2 vertices!");
                }

                var vertex = new Vertex(vertices[0]);

                for (var i = 1; i < vertices.Length; i++)
                {
                    vertex.AddNeighbour(new Vertex(vertices[i]));
                }

                graph.AddVertex(vertex);
            }

            return graph;
        }
    }
}
