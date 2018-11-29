namespace DataStructures
{
    interface INode
    {
        object Value { get; set; }
    }

    interface INode<T> : INode
    {
        new T Value { get; set; }
    }
}
