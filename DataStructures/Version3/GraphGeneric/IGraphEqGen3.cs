using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3.GraphGeneric
{
    public interface IGraphEqGen3<EdgeType, T> where EdgeType : Unilateral_EdgeE3<T> where T : IEquatable<T>
    {
        ISet<T> Nodes { get; }
        ISet<EdgeType> Edges { get; }
    }
}
