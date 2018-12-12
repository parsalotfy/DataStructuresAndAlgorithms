using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph<T>
    {
        IEnumerable<INode<T>> Nodes { get; }
        IEnumerable<IEdge<T>> Edges { get; }
    }
}