namespace DataStructures
{
    public class Node<T> : Node, INode<T>
    {
        public Node(T nodeValue) : base(nodeValue)
        {
            _value = nodeValue;
        }



        private readonly T _value;
        public new T Value
        {
            get { return _value; }
        }

    }
}

