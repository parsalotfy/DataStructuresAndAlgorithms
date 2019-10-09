using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph<T>
    {
        IEnumerable<T> Nodes { get; }
        IEnumerable<IEdge<T>> Edges { get; }
    }
}