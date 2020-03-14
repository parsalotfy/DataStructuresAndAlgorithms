using System.Collections.Generic;

namespace DataStructures.Comparer
{
    public interface IGraphC<T>
    {
        ISet<T> Nodes { get; }
        ISet<IEdgeC<T>> Edges { get; }
    }
}