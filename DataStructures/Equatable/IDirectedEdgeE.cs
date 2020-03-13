using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Equatable
{
    public interface IDirectedEdgeE<T> : IEdgeE<T>, IEquatable<IDirectedEdgeE<T>> where T : IEquatable<T>
    {
        T Source { get; }
        T Target { get; }
    }
}
