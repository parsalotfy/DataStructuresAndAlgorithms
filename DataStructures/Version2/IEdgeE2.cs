using System;

namespace DataStructures.Version2
{    
    public interface IEdgeE2<T> : IEquatable<IEdgeE2<T>> where T : IEquatable<T>
    {
        T Source { get; }
        T Target { get; }
    }   
}