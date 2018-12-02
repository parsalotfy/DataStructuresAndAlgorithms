namespace DataStructures
{
    public interface IEdge
    {
        INode A_Node { get; }
        INode Another_Node { get; }

        void UpdateValue(INode a_NodeValue, INode another_NodeValue);
    }

    public interface IEdge<T> : IEdge
    {
        new INode<T> A_Node { get; }
        new INode<T> Another_Node { get; }

        void UpdateValue(INode<T> a_NodeValue, INode<T> another_NodeValue);
    }
}