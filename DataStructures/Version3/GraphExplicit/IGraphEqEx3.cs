using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3.GraphExplicit
{
    public interface IGraphEqEx3<T> where T : IEquatable<T>
    {
        ISet<T> Nodes { get; }
        ISet<Unilateral_EdgeE3<T>> Edges { get; }
    }
}
