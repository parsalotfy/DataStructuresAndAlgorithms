namespace DataStructures
{
    public interface INode
    {
        object Value { get; }

        void UpdateValue(object nodeValue);
    }

    public interface INode<T> : INode
    {
        new T Value { get; }

        void UpdateValue(T nodeValue);
    }
}
