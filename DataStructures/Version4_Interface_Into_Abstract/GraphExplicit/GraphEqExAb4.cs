using System;
using System.Collections.Generic;

namespace DataStructures.Version4_Interface_Into_Abstract.GraphExplicit
{
    public abstract class GraphEqExAb4<T> where T : IEquatable<T>
    {
        ISet<T> Nodes { get; }
        ISet<EdgeE4<T>> Edges { get; }

        public abstract bool AddNode(T node);
        public abstract bool AddEdge(EdgeE4<T> edge);
        public abstract bool RemoveNode(T node);
        public abstract bool RemoveEdge(EdgeE4<T> edge);
        public abstract void ClearGraph();
    }
}
