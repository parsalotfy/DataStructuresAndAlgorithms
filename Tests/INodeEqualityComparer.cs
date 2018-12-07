using System.Collections.Generic;
using DataStructures;

namespace Tests
{
    public class INodeEqualityComparer : EqualityComparer<INode>
    {
        private INodeEqualityComparer()
        {

        }

        private static readonly INodeEqualityComparer _instance = new INodeEqualityComparer();
        public static INodeEqualityComparer Instance
        {
            get { return _instance; }
        }

        public override bool Equals(INode x, INode y)
        {
            return (int)(x.Value) == (int)(y.Value);
        }

        public override int GetHashCode(INode obj)
        {
            return ((int)(obj.Value)).GetHashCode();
        }
    }
}