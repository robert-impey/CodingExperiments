using System.Collections.Generic;

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
    }
}
