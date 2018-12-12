namespace DataStructures
{
    public interface IEdge<T>
    {
        INode<T> A_Node { get; }
        INode<T> Another_Node { get; }
    }
}