namespace DataStructures
{
    public interface IEdge<T>
    {
        INode<T> A_Node { get; set; }
        INode<T> Another_Node { get; set; }
    }
}