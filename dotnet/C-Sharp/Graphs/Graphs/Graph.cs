using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    public class Graph
    {
        private readonly ISet<Vertex> _vertices;

        public IReadOnlySet<Vertex> Vertices 
        { 
            get
            {
                return (IReadOnlySet<Vertex>)_vertices;
            }
        }

        public Graph()
        {
            _vertices = new HashSet<Vertex>();
        }

        public void AddVertex(Vertex vertex)
        {
            _vertices.Add(vertex);
        }

        public IEnumerable<Tuple<Vertex, Vertex>> GetEdges()
        {
            var edges = new List<Tuple<Vertex, Vertex>>();

            foreach (var vertex in Vertices)
            {
                foreach (var neighbour in vertex.Neighbours)
                {
                    if (!edges.Any(t => (t.Item1.Value == vertex.Value && t.Item2.Value == neighbour.Value) 
                        || (t.Item2.Value == vertex.Value && t.Item1.Value == neighbour.Value)))
                    {
                        edges.Add(new Tuple<Vertex, Vertex>(vertex, neighbour));
                    }
                }
            }

            return edges;
        }
    }
}
