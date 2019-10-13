using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph<T>
    {
        ISet<T> Nodes { get; }
        ISet<IEdge<T>> Edges { get; }
    }
}