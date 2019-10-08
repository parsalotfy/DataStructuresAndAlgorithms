namespace DataStructures
{
    public interface IEdge<T>
    {
        T A_Node { get; }
        T Another_Node { get; }
    }
}