namespace DataStructures
{
    public interface IEdge<T> : IEdge
    {
        new INode<T> A_Node { get; }
        new INode<T> Another_Node { get; }


        void UpdateEdge(T a_NodeValue, T another_NodeValue);
        void Update_A_Node(T a_NodeValue);
        void Update_Another_Node(T another_NodeValue);

        void UpdateEdge(INode<T> a_NodeValue, INode<T> another_NodeValue);
        void Update_A_Node(INode<T> a_NodeValue);
        void Update_Another_Node(INode<T> another_NodeValue);
    }
}