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

        public object Value { get; private set; }

        public virtual void UpdateValue(object nodeValue)
        {
            Value = nodeValue;
        }
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


        public new T Value { get; private set; }

        public virtual void UpdateValue(T nodeValue)
        {
            base.UpdateValue(nodeValue);
            Value = nodeValue;
        }
    }
}

