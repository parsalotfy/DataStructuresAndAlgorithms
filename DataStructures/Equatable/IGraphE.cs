using System;
using System.Collections.Generic;

namespace DataStructures.Equatable
{
    public interface IGraphE<T> where T : IEquatable<T>
    {
        ISet<T> Nodes { get; }
        ISet<IEdgeE<T>> Edges { get; }
    }
}