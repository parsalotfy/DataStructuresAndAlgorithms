using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph<T> : IGraph
    {
        new IEnumerable<INode<T>> Nodes { get; }
        new IEnumerable<IEdge<T>> Edges { get; }
    }
}