namespace DataStructures
{
    public interface INode
    {
        object Value { get; }

        void UpdateValue(object nodeValue);
    }
}
