using System.Collections.Generic;

namespace DataStructures
{
// Ctors
// Ctors chaining
// IEquality
// Update method for Node and Edge
// add overloads of Update(object) to IEdge and IEdgeT
//

    public interface IGraph<T> : IGraph
    {
        new ISet<INode<T>> Nodes { get; set; }
        new ISet<IEdge<T>> Edges { get; set; }
    }
}