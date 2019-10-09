using System.Collections.Generic;
using DataStructures;

namespace Tests
{
    public class IEdgeStudentEqualityComparer : EqualityComparer<IEdge<Student>>
    {
        private IEdgeStudentEqualityComparer()
        {

        }

        private static readonly IEdgeStudentEqualityComparer _instance =
        new IEdgeStudentEqualityComparer();

        public static IEdgeStudentEqualityComparer Instance
        {
            get { return _instance; }
        }

        public override bool Equals(IEdge<Student> x, IEdge<Student> y)
        {
            //return INodeStudentEqualityComparer.Instance.Equals(x.A_Node, y.A_Node) && INodeStudentEqualityComparer.Instance.Equals(x.Another_Node, y.Another_Node);
            return false;
        }

        public override int GetHashCode(IEdge<Student> edge)
        {
            //return INodeStudentEqualityComparer.Instance.GetHashCode(edge.A_Node) ^ INodeStudentEqualityComparer.Instance.GetHashCode(edge.Another_Node);
            return 0;
        }
    }
}