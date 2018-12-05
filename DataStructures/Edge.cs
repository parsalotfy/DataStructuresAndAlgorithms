namespace DataStructures
{

    public class Edge : IEdge
    {

        #region  Constructors

        public Edge()
        {
            A_Node = new Node();
            Another_Node = new Node();
        }

        public Edge(object a_Node, object another_Node)
        {
            UpdateEdge(a_Node, another_Node);
        }

        public Edge(INode a_Node, INode another_Node)
        {
            UpdateEdge(a_Node, another_Node);
        }

        #endregion Constructors


        #region  Properties


        private INode _a_Node;
        public INode A_Node
        {
            get { return _a_Node; }
            set { _a_Node = value; }
        }


        private INode _another_Node;
        public INode Another_Node
        {
            get { return _another_Node; }
            set { _another_Node = value; }
        }



        #endregion  Properties


        #region  Methods

        public void Update_A_Node(object a_NodeValue)
        {
            A_Node = new Node(a_NodeValue);
        }

        public void Update_Another_Node(object another_NodeValue)
        {
            Another_Node = new Node(another_NodeValue);
        }

        public void UpdateEdge(object a_NodeValue, object another_NodeValue)
        {
            Update_A_Node(a_NodeValue);
            Update_Another_Node(another_NodeValue);
        }


        public void UpdateEdge(INode a_NodeValue, INode another_NodeValue)
        {
            A_Node = a_NodeValue;
            Another_Node = another_NodeValue;
        }

        #endregion  Methods


    }
}