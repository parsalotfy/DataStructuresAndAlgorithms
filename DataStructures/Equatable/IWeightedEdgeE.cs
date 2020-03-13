using System;

namespace DataStructures.Equatable
{
    public interface IWeightedEdgeE<T> : ILabeledEdgeE<T>, IEquatable<IWeightedEdgeE<T>> where T : IEquatable<T>
    {
        int Weight { get; }
    }
}