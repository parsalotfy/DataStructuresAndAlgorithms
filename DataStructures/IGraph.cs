using System.Collections.Generic;

namespace DataStructures
{
    public interface IGraph
    {
        ISet<INode> Nodes { get; set; }
        ISet<IEdge> Edges { get; set; }
    }



    public interface IGraph<T>
    {
        ISet<INode<T>> Nodes { get; set; }
        ISet<IEdge<T>> Edges { get; set; }
    }
}