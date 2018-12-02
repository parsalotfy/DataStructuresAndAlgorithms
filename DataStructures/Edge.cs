namespace DataStructures
{

    public class Edge : IEdge
    {

        #region  Constructors

        public Edge()
        {

        }

        public Edge(object a_Node, object another_Node)
        {
            UpdateValue(a_Node, another_Node);
        }

        public Edge(INode a_Node, INode another_Node)
        {
            UpdateValue(a_Node, another_Node);
        }

        #endregion Constructors


        #region  Properties

        public INode A_Node { get; private set; }

        public INode Another_Node { get; private set; }

        #endregion  Properties


        #region  Methods

        public virtual void UpdateValue(object a_NodeValue, object another_NodeValue)
        {
            A_Node = new Node(a_NodeValue);
            Another_Node = new Node(another_NodeValue);
        }

        public virtual void UpdateValue(INode a_NodeValue, INode another_NodeValue)
        {
            A_Node = a_NodeValue;
            Another_Node = another_NodeValue;
        }

        #endregion  Methods


    }





    public class Edge<T> : Edge, IEdge<T>
    {
        #region Constructors

        // No object and INode Constructor

        public Edge() : base()
        {

        }

        public Edge(T a_Node, T another_Node) : base(a_Node, another_Node)
        {
            UpdateValue(a_Node, another_Node);
        }

        public Edge(INode<T> a_Node, INode<T> another_Node) : base(a_Node, another_Node)
        {
            UpdateValue(a_Node, another_Node);
        }

        #endregion Constructors


        #region Properties

        public new INode<T> A_Node { get; private set; }

        public new INode<T> Another_Node { get; private set; }

        #endregion Properties


        #region  Methods

        public virtual void UpdateValue(T a_NodeValue, T another_NodeValue)
        {
            A_Node = new Node<T>(a_NodeValue);
            Another_Node = new Node<T>(another_NodeValue);
        }

        public virtual void UpdateValue(INode<T> a_NodeValue, INode<T> another_NodeValue)
        {
            A_Node = a_NodeValue;
            Another_Node = another_NodeValue;
        }

        #endregion  Methods
    }
}