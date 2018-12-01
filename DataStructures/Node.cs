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
        public Node():base()
        {

        }

        public Node(T nodeValue):base(nodeValue)
        {
            Value = nodeValue;
        }

        public new T Value { get; set; }
    }
}

