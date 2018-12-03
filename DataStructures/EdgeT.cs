namespace DataStructures
{
    public class Edge<T> : Edge, IEdge<T>
    {
        #region Constructors

        // No object and INode Constructor

        public Edge()
        {

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

        public new INode<T> A_Node { get; private set; }

        public new INode<T> Another_Node { get; private set; }


        #endregion Properties


        #region  Methods


        public virtual void Update_A_Node(T a_NodeValue)
        {
            A_Node = new Node<T>(a_NodeValue);
            base.Update_A_Node(a_NodeValue);
        }

        public virtual void Update_Another_Node(T another_NodeValue)
        {
            Another_Node = new Node<T>(another_NodeValue);
            base.Update_Another_Node(another_NodeValue);
        }

        public virtual void UpdateEdge(T a_NodeValue, T another_NodeValue)
        {
            Update_A_Node(a_NodeValue);
            Update_Another_Node(another_NodeValue);
            // No need to call base!
        }





        public virtual void Update_A_Node(INode<T> a_NodeValue)
        {
            A_Node=a_NodeValue;
            base.Update_A_Node(a_NodeValue);
        }

        public virtual void Update_Another_Node(INode<T> another_NodeValue)
        {
            Another_Node=another_NodeValue;
            base.Update_Another_Node(another_NodeValue);
        }

        public virtual void UpdateEdge(INode<T> a_NodeValue, INode<T> another_NodeValue)
        {
            Update_A_Node(a_NodeValue);
            Update_Another_Node(another_NodeValue);
            // No need to call base!
        }

        #endregion  Methods
    }
}