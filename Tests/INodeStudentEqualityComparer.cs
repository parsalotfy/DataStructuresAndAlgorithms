using System.Collections.Generic;
using DataStructures;

namespace Tests
{
    public class INodeStudentEqualityComparer : EqualityComparer<INode<Student>>
    {
        private INodeStudentEqualityComparer()
        {

        }

        private static readonly INodeStudentEqualityComparer _instance =
        new INodeStudentEqualityComparer();
        
        
        public static INodeStudentEqualityComparer Instance
        {
            get { return _instance; }
        }

        public override bool Equals(INode<Student> x, INode<Student> y)
        {
            return x.Value.ID == y.Value.ID;
        }

        public override int GetHashCode(INode<Student> studentNode)
        {
            return studentNode.Value.ID.GetHashCode();
        }
    }
}