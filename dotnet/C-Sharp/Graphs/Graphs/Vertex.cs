using System.Collections.Generic;

namespace Graphs
{
    public class Vertex
    {
        public string Value { get; }
        public ISet<Vertex> Neighbours { get; }

        public Vertex(string value)
        {
            Value = value;
            Neighbours = new HashSet<Vertex>();
        }
    }
}
