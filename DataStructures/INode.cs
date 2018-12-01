namespace DataStructures
{
    public interface INode
    {
        object Value { get; set; }
    }

    public interface INode<T> : INode
    {
        new T Value { get; set; }
    }
}
