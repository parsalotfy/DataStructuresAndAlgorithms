namespace DataStructures
{

    public class Node : INode
    {
        public Node()
        {

        }

        public Node(object nodeValue)
        {
            Value = nodeValue;
        }

        public object Value { get; set; }
    }



    public class Node<T> : Node, INode<T>
    {
        public Node() : base()
        {

        }

        public Node(T nodeValue) : base(nodeValue)
        {
            Value = nodeValue;
        }


        private T _value;
        public new T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                base.Value = value;
            }
        }

    }
}

