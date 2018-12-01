namespace DataStructures
{
    public interface IEdge
    {
        INode A_Node { get; set; }
        INode Another_Node { get; set; }
    }

    public interface IEdge<T> : IEdge
    {
        new INode<T> A_Node { get; set; }
        new INode<T> Another_Node { get; set; }
    }
}