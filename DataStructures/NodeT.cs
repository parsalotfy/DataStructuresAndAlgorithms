namespace DataStructures
{
    public class Node<T> : Node, INode<T>
    {
        public Node() : base()
        {

        }

        public Node(T nodeValue) : base(nodeValue)
        {
            Value = nodeValue;
        }


        public new T Value { get; private set; }

        public virtual void UpdateValue(T nodeValue)
        {
            base.UpdateValue(nodeValue);
            Value = nodeValue;
        }
    }
}

