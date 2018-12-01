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



    public class Node<T> : INode<T>
    {
        public Node()
        {

        }

        public Node(T nodeValue)
        {
            Value = nodeValue;
        }

        public T Value { get; set; }
        object INode.Value { get { return Value; } set { Value = (T)value; } }
    }
}

