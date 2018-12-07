using System.Collections.Generic;
using DataStructures;

namespace Tests
{
    public class IEdgeEqualityComparer : EqualityComparer<IEdge>
    {
        private IEdgeEqualityComparer()
        {

        }

        private static readonly IEdgeEqualityComparer _instance = new IEdgeEqualityComparer();
        public static IEdgeEqualityComparer Instance
        {
            get { return _instance; }
        }

        public override bool Equals(IEdge x, IEdge y)
        {
            return INodeEqualityComparer.Instance.Equals(x.A_Node, y.A_Node) &&
                   INodeEqualityComparer.Instance.Equals(x.Another_Node, y.Another_Node);
        }

        public override int GetHashCode(IEdge obj)
        {
            return INodeEqualityComparer.Instance.GetHashCode(obj.A_Node) ^
                   INodeEqualityComparer.Instance.GetHashCode(obj.Another_Node);
        }
    }
}