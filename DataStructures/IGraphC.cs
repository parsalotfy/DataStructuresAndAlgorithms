using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraphC<T>
    {
        ISet<T> Nodes { get; }
        ISet<IEdgeC<T>> Edges { get; }
    }
}