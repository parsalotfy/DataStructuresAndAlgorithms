namespace DataStructures
{
    public interface IEdge<T> : IEdge
    {
        new INode<T> A_Node { get; }
        new INode<T> Another_Node { get; }

        void UpdateValue(INode<T> a_NodeValue, INode<T> another_NodeValue);
    }
}