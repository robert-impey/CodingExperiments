using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Vertex
    {
        public string Value { get; }
        public IList<Vertex> Neighbours { get; }

        public Vertex(string value)
        {
            Value = value;
            Neighbours = new List<Vertex>();
        }

        public void PrintDot()
        {
            foreach (var neighbour in Neighbours)
            {
                Console.WriteLine($"\t{Value} -- {neighbour.Value}");
            }
        }
    }
}
