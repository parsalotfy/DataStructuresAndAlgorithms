using System;

namespace DataStructures.Equatable
{
    public interface IEdgeE<T> : IEquatable<IEdgeE<T>> where T : IEquatable<T>
    {
        T A_Node { get; }
        T Another_Node { get; }
    }
}