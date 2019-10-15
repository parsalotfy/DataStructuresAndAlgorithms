using System;

namespace DataStructures
{
    public interface IEdgeE<T> : IEquatable<IEdgeE<T>> where T : IEquatable<T>
    {
        T A_Node { get; }
        T Another_Node { get; }
    }
}
