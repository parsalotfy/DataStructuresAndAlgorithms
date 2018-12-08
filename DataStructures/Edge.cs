namespace DataStructures
{

    public class Edge : IEdge
    {

        #region  Constructors

        public Edge(object a_Node, object another_Node)
        {
            _a_Node = new Node(a_Node);
            _another_Node = new Node(another_Node);
        }

        public Edge(INode a_Node, INode another_Node)
        {
            _a_Node = a_Node;
            _another_Node = another_Node;
        }

        #endregion Constructors




        #region  Properties

        private readonly INode _a_Node;
        public INode A_Node
        {
            get { return _a_Node; }
        }

        private readonly INode _another_Node;
        public INode Another_Node
        {
            get { return _another_Node; }
        }

        #endregion  Properties
    }
}