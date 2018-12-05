namespace DataStructures
{
    public interface IEdge<T> : IEdge
    {
        new INode<T> A_Node { get; set; }
        new INode<T> Another_Node { get; set; }
    }
}