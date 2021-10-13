using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        public ISet<Vertex> Vertices;

        public Graph()
        {
            Vertices = new HashSet<Vertex>();
        }
    }
}
