namespace DataStructures
{
    public class Edge<T> : IEdge<T>
    {
        #region Constructors

        // No object and INode Constructor
        public Edge(T a_Node, T another_Node)
        {
            _a_Node = new Node<T>(a_Node);
            _another_Node = new Node<T>(another_Node);
        }

        public Edge(INode<T> a_Node, INode<T> another_Node)
        {
            _a_Node = a_Node;
            _another_Node = another_Node;
        }

        #endregion Constructors


        #region Properties

        private readonly INode<T> _a_Node;
        public INode<T> A_Node
        {
            get { return _a_Node; }
        }


        private readonly INode<T> _another_Node;
        public INode<T> Another_Node
        {
            get { return _another_Node; }
        }

        #endregion Properties

    }
}