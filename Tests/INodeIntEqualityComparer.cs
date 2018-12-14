using System.Collections.Generic;
using DataStructures;

namespace Tests
{
    public class INodeIntEqualityComparer : EqualityComparer<INode<int>>
    {
        private INodeIntEqualityComparer()
        {

        }

        private static readonly INodeIntEqualityComparer _instance =
        new INodeIntEqualityComparer();
        
        
        public static INodeIntEqualityComparer Instance
        {
            get { return _instance; }
        }

        public override bool Equals(INode<int> x, INode<int> y)
        {
            return x.Value == y.Value;
        }

        public override int GetHashCode(INode<int> studentNode)
        {
            return studentNode.Value.GetHashCode();
        }
    }
}