using System;

namespace DataStructures
{
    public interface ILabeledEdgeE<T> : IEdgeE<T>, IEquatable<ILabeledEdgeE<T>> where T : IEquatable<T>
    {
        string Label { get; }
    }
}