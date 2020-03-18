using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3_MoreInterface_MoreEquatable
{
    public interface IEdgeE3<T> : IEquatable<IEdgeE3<T>> where T : IEquatable<T>
    {
        T Source { get; }
        T Target { get; }
    }
}
