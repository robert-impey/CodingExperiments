using System.Collections.Generic;

namespace Graphs
{
    public class Vertex
    {
        private readonly ISet<Vertex> _neighbours;

        public string Value { get; }
        public IReadOnlySet<Vertex> Neighbours
        {
            get
            {
                return (IReadOnlySet<Vertex>)_neighbours;
            }
        }

        public Vertex(string value)
        {
            Value = value;
            _neighbours = new HashSet<Vertex>();
        }

        public void AddNeighbour(string neighbour)
        {
            _neighbours.Add(new Vertex(neighbour));
        }
    }
}
