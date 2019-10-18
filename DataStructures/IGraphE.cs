using System;
using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraphE<T> where T : IEquatable<T>
    {
        ISet<T> Nodes { get; }
        ISet<IEdgeE<T>> Edges { get; }
    }
}