using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        public IList<Vertex> Vertices;

        public Graph()
        {
            Vertices = new List<Vertex>();
        }
    }
}
