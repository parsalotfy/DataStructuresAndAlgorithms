using System;

namespace DataStructures
{
    // https://stackoverflow.com/questions/9316918/what-is-the-difference-between-iequalitycomparert-and-iequatablet
    // https://stackoverflow.com/questions/8952003/how-does-hashset-compare-elements-for-equality/15413983
    // https://stackoverflow.com/questions/58379115/iequatablet-with-gethashcode
    // https://stackoverflow.com/questions/19791178/force-child-class-to-override-function-of-ancestor-via-parent
    // https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netframework-4.8
    // https://softwareengineering.stackexchange.com/questions/307999/can-i-enforce-the-overriding-of-gethashcode-and-equals-methods-for-users-of
    // https://stackoverflow.com/questions/49055673/should-gethashcode-be-implemented-for-iequatablet-on-mutable-types

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