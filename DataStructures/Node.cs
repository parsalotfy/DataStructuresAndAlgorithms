namespace DataStructures
{
    public class Node<T> : INode<T>
    {
        public Node()
        {
            
        }

        public Node(T nodeValue)
        {
            Value=nodeValue;
        }

        public T Value { get; set; }
    }
}

