using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph<T> : IGraph
    {
        new ISet<INode<T>> Nodes { get; }
        new ISet<IEdge<T>> Edges { get; }
    }
}