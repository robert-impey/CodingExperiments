using System;
using System.Collections.Generic;
using System.IO;

namespace Graphs
{
    public class Graph
    {
        public IList<Vertex> Vertices;

        public Graph()
        {
            Vertices = new List<Vertex>();
        }

        public void PrintDot()
        {
            Console.WriteLine("graph {");

            foreach (var vertex in Vertices)
            {
                vertex.PrintDot();
            }

            Console.WriteLine("}");
        }

        public void ReadFile(string fileName)
        {
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
                    vertex.Neighbours.Add(new Vertex(vertices[i]));
                }

                Vertices.Add(vertex);
            }
        }
    }
}
