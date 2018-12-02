namespace DataStructures
{

    public class Node : INode
    {
        public Node()
        {

        }

        public Node(object nodeValue)
        {
            UpdateValue(nodeValue);
        }

        public object Value { get; private set; }

        public virtual void UpdateValue(object nodeValue)
        {
            Value = nodeValue;
        }
    }
}

