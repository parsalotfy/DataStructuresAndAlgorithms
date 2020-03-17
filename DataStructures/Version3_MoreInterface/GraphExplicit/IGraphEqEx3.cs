using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3_MoreInterface.GraphExplicit
{
    public interface IGraphEqEx3<T> where T : IEquatable<T>
    {
        ISet<T> Nodes { get; }
        ISet<IEdgeE3<T>> Edges { get; }

        bool AddNode(T node);
        bool AddEdge(IEdgeE3<T> edge);
        bool RemoveNode(T node);
        bool RemoveEdge(IEdgeE3<T> edge);
        void ClearGraph();
    }
}
