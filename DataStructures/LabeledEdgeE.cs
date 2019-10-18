using System;

namespace DataStructures
{
    public class LabeledEdgeE<T> : ILabeledEdgeE<T>, IEquatable<LabeledEdgeE<T>> where T : IEquatable<T>
    {

        #region Constructors

        public LabeledEdgeE(T a_Node, T another_Node, string label)
        {
            A_Node = a_Node;
            Another_Node = another_Node;
            Label = label;
        }

        #endregion Constructors


        #region Properties

        public T A_Node { get; }


        public T Another_Node { get; }


        public string Label { get; }

        #endregion Properties



        #region IEquatable_Implementation

        public bool Equals(ILabeledEdgeE<T> other)
        {
            return EdgeE<T>.Equals(this, other) && Label.Equals(other.Label);

            /*return ((A_Node.Equals(other.A_Node) && Another_Node.Equals(other.Another_Node)) ||
                   (A_Node.Equals(other.Another_Node) && Another_Node.Equals(other.A_Node))) &&
                   Label.Equals(other.Label);*/
        }

        public bool Equals(LabeledEdgeE<T> other)
        {
            return Equals(other as ILabeledEdgeE<T>);
        }

        public bool Equals(IEdgeE<T> other)
        {
            return Equals(other as ILabeledEdgeE<T>);
        }

        public override int GetHashCode()
        {
            return A_Node.GetHashCode() ^ Another_Node.GetHashCode() ^ Label.GetHashCode();
        }

        #endregion IEquatable_Implementation
    }
}