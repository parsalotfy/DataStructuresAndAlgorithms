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
            set { UpdateValue(value); }
        }



        #endregion Properties



        #region Methods

        // Just should be used in Setter
        private void UpdateValue(object nodeValue)
        {
            _value = nodeValue;
        }

        #endregion Methods


    }
}

