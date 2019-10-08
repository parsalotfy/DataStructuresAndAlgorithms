namespace DataStructures
{
    public class Edge<T> : IEdge<T>
    {
        #region Constructors

        public Edge(T a_Node, T another_Node)
        {
            _a_Node = a_Node;
            _another_Node = another_Node;
        }

        #endregion Constructors


        #region Properties

        private readonly T _a_Node;
        public T A_Node
        {
            get { return _a_Node; }
        }


        private readonly T _another_Node;
        public T Another_Node
        {
            get { return _another_Node; }
        }

        #endregion Properties

    }
}