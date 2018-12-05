namespace DataStructures
{
    public class Node<T> : Node, INode<T>
    {
        public Node()
        {

        }

        public Node(T nodeValue)
        {
            Value = nodeValue;
        }



        private T _value;
        public new T Value
        {
            get { return _value; }
            set
            {
                _value = value;
                base.Value = value;
            }
        }

    }
}

