namespace DataStructures
{

    public class Node : INode
    {
        #region Constructors

        public Node()
        {

        }

        public Node(object nodeValue)
        {
            UpdateValue(nodeValue);
        }

        #endregion Constructors



        #region Properties

        public object Value { get; private set; }

        #endregion Properties



        #region Methods

        public virtual void UpdateValue(object nodeValue)
        {
            Value = nodeValue;
        }

        #endregion Methods


    }
}

