namespace DataStructures
{
    public class Node<T> : INode<T>
    {
        public Node(T nodeValue)
        {
            _value = nodeValue;
        }



        private readonly T _value;
        public T Value
        {
            get { return _value; }
        }

    }
}

