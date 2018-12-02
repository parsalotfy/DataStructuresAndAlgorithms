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
}