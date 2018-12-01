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

    public class Edge<T> : Edge, IEdge<T>
    {
        public Edge() : base()
        {

        }

        public Edge(INode<T> a_Node, INode<T> another_Node) : base(a_Node, another_Node)
        {
            A_Node = a_Node;
            Another_Node = another_Node;
        }

        public Edge(T a_Node, T another_Node) : base(a_Node, another_Node)
        {
            A_Node = new Node<T>(a_Node);
            Another_Node = new Node<T>(another_Node);
        }

        public new INode<T> A_Node
        {
            get
            {
                return A_Node;
            }
            set
            {
                A_Node=value;
                base.A_Node=value;
            }
        }
        
        public new INode<T> Another_Node 
        {
             get
            {
                return Another_Node;
            }
            set
            {
                Another_Node=value;
                base.Another_Node=value;
            }
        }
    }
}