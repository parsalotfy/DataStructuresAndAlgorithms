namespace DataStructures
{

    public class Edge : IEdge
    {

        public Edge()
        {

        }

        public Edge(INode a_Node, INode another_Node)
        {
            A_Node = a_Node;
            Another_Node = another_Node;
        }

        public Edge(object a_Node, object another_Node)
        {
            A_Node = new Node(a_Node);
            Another_Node = new Node(another_Node);
        }

        public INode A_Node { get; set; }
        public INode Another_Node { get; set; }
    }

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

        INode IEdge.A_Node { get { return A_Node; } set { A_Node = (INode<T>)value; } }
        INode IEdge.Another_Node { get => Another_Node; set => throw new System.NotImplementedException(); }
    }
}