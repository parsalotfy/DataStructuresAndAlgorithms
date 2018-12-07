using System.Collections.Generic;

namespace DataStructures
{
    public class Graph<T> : Graph, IGraph
    {
        public new HashSet<INode<T>> Nodes { get; set; }

        public new HashSet<IEdge<T>> Edges { get; set; }
    }
}