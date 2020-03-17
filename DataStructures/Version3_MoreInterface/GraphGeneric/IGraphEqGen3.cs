using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3_MoreInterface.GraphGeneric
{
    public interface IGraphEqGen3<EdgeType, T> where EdgeType : IEdgeE3<T> where T : IEquatable<T>
    {
        ISet<T> Nodes { get; }
        ISet<EdgeType> Edges { get; }


        bool AddNode(T node);
        bool AddEdge(EdgeType edge);
        bool RemoveNode(T node);
        bool RemoveEdge(EdgeType edge);
        void ClearGraph();
    }
}
