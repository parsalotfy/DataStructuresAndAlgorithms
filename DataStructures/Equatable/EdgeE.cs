using System;

namespace DataStructures.Equatable
{
    public class EdgeE<T> : IEdgeE<T>, IEquatable<EdgeE<T>> where T : IEquatable<T>
    {

        #region Constructors

        public EdgeE(T a_Node, T another_Node)
        {
            A_Node = a_Node;
            Another_Node = another_Node;
        }

        #endregion Constructors


        #region Properties

        public T A_Node { get; }


        public T Another_Node { get; }

        #endregion Properties



        #region IEquatable_Implementation

        public bool Equals(IEdgeE<T> other)
        {
            return (A_Node.Equals(other.A_Node) && Another_Node.Equals(other.Another_Node)) ||
                   (A_Node.Equals(other.Another_Node) && Another_Node.Equals(other.A_Node));
        }

        public bool Equals(EdgeE<T> other)
        {
            return Equals(other as IEdgeE<T>);
        }


        public override int GetHashCode()
        {
            return A_Node.GetHashCode() ^ Another_Node.GetHashCode();
        }

        #endregion IEquatable_Implementation

    }
}