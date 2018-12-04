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
            set { UpdateValue(value); }
        }

        // Just should be used in Setter
        private void UpdateValue(T nodeValue)
        {
            _value = nodeValue;
            base.Value = nodeValue;
        }
    }
}

