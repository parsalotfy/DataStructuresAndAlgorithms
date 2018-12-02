namespace DataStructures
{
    public class Node<T> : Node, INode<T>
    {
        public Node()
        {

        }

        public Node(T nodeValue)
        {
            UpdateValue(nodeValue);
        }


        public new T Value { get; private set; }

        public virtual void UpdateValue(T nodeValue)
        {
            Value = nodeValue;
            base.UpdateValue(nodeValue);
        }
    }
}

