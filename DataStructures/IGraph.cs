using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph
    {
        ISet<INode> Nodes { get; set; }
        ISet<IEdge> Edges { get; set; }
    }

// Ctors
// Ctors chaining
// IEquality
// Update method for Node and Edge
// add overloads of Update(object) to IEdge and IEdgeT
//
}