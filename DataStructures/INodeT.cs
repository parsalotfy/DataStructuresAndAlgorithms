namespace DataStructures
{
    public interface INode<T> : INode
    {
        new T Value { get; }
    }
}
