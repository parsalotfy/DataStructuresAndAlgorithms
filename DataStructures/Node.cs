namespace DataStructures
{

    public class Node : INode
    {
        public Node(object nodeValue)
        {
            _value = nodeValue;
        }

        private readonly object _value;
        public object Value
        {
            get { return _value; }
        }
    }
}

