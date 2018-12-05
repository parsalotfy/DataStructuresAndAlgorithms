namespace DataStructures
{
    public class Edge<T> : Edge, IEdge<T>
    {
        #region Constructors

        // No object and INode Constructor

        public Edge()
        {
            A_Node=new Node<T>();
            Another_Node=new Node<T>();
        }

        public Edge(T a_Node, T another_Node) // No need to call base!
        {
            UpdateEdge(a_Node, another_Node);
        }

        public Edge(INode<T> a_Node, INode<T> another_Node) // No need to call base!
        {
            UpdateEdge(a_Node, another_Node);
        }

        #endregion Constructors


        #region Properties


        private INode<T> _a_Node;
        public new INode<T> A_Node
        {
            get { return _a_Node; }
            set
            {
                _a_Node = value;
                base.A_Node = value;
            }
        }


        private INode<T> _another_Node;
        public new INode<T> Another_Node
        {
            get { return _another_Node; }
            set
            {
                _another_Node = value;
                base.Another_Node = value;
            }
        }





        #endregion Properties


        #region  Methods


        public void Update_A_Node(T a_NodeValue)
        {
            A_Node = new Node<T>(a_NodeValue);
            base.Update_A_Node(a_NodeValue);
        }

        public void Update_Another_Node(T another_NodeValue)
        {
            Another_Node = new Node<T>(another_NodeValue);
            base.Update_Another_Node(another_NodeValue);
        }

        public void UpdateEdge(T a_NodeValue, T another_NodeValue)
        {
            Update_A_Node(a_NodeValue);
            Update_Another_Node(another_NodeValue);
            // No need to call base!
        }



        public void UpdateEdge(INode<T> a_NodeValue, INode<T> another_NodeValue)
        {
            A_Node = a_NodeValue;
            Another_Node = another_NodeValue;
            // No need to call base!
        }

        #endregion  Methods
    }
}