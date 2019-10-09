using System.Collections.Generic;
using DataStructures;

namespace Tests
{
    public class IEdgeIntEqualityComparer : EqualityComparer<IEdge<int>>
    {
        private IEdgeIntEqualityComparer()
        {

        }

        private static readonly IEdgeIntEqualityComparer _instance =
        new IEdgeIntEqualityComparer();

        public static IEdgeIntEqualityComparer Instance
        {
            get { return _instance; }
        }

        public override bool Equals(IEdge<int> x, IEdge<int> y)
        {
            //return INodeIntEqualityComparer.Instance.Equals(x.A_Node, y.A_Node) && INodeIntEqualityComparer.Instance.Equals(x.Another_Node, y.Another_Node);
            return false;
        }

        public override int GetHashCode(IEdge<int> edge)
        {
            //return INodeIntEqualityComparer.Instance.GetHashCode(edge.A_Node) ^ INodeIntEqualityComparer.Instance.GetHashCode(edge.Another_Node);
            return 0;
        }
    }
}