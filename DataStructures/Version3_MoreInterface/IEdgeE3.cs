using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3_MoreInterface
{
    public interface IEdgeE3<out T> where T : IEquatable<T>
    {
        T Source { get; }
        T Target { get; }
    }
}
