namespace DataStructures
{
    public interface IEdge
    {
        INode A_Node { get; }
        INode Another_Node { get; }

        #region Removable
        void UpdateEdge(object a_NodeValue, object another_NodeValue);
        void Update_A_Node(object a_NodeValue);
        void Update_Another_Node(object another_NodeValue);
        #endregion Removable


        void UpdateEdge(INode a_NodeValue, INode another_NodeValue);
        void Update_A_Node(INode a_NodeValue);
        void Update_Another_Node(INode another_NodeValue);
    }
}