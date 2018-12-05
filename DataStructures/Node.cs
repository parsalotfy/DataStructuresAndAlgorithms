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
            Value = nodeValue;
        }

        #endregion Constructors



        #region Properties


        private object _value;
        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }



        #endregion Properties



        #region Methods


        #endregion Methods


    }
}

