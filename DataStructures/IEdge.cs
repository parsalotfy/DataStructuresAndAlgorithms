namespace DataStructures
{
    public interface IEdge
    {
        INode A_Node { get; }
        INode Another_Node { get; }

        void UpdateValue(INode a_NodeValue, INode another_NodeValue);
    }
}