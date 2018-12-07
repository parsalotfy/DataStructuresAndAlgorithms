using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph
    {
        IEnumerable<INode> Nodes { get; }
        IEnumerable<IEdge> Edges { get; }
    }
}