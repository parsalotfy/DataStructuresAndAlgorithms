namespace DataStructures
{
    public class Edge<T> : IEdge<T>
    {
        public Edge()
        {

        }

        public Edge(INode<T> a_Node, INode<T> another_Node)
        {
            A_Node = a_Node;
            Another_Node = another_Node;
        }

        public Edge(T a_Node, T another_Node)
        {
            A_Node = new Node<T>(a_Node);
            Another_Node = new Node<T>(another_Node);
        }

        public INode<T> A_Node { get; set; }
        public INode<T> Another_Node { get; set; }
    }
}