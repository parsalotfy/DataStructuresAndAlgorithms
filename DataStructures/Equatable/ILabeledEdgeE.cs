using System;

namespace DataStructures.Equatable
{
    public interface ILabeledEdgeE<T> : IEdgeE<T>, IEquatable<ILabeledEdgeE<T>> where T : IEquatable<T>
    {
        string Label { get; }
    }
}