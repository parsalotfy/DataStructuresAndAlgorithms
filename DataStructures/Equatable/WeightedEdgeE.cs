using System;

namespace DataStructures.Equatable
{
    public class WeightedEdgeE<T> : IWeightedEdgeE<T>, IEquatable<WeightedEdgeE<T>> where T : IEquatable<T>
    {

        #region Constructors

        public WeightedEdgeE(T a_Node, T another_Node, int weight)
        {
            A_Node = a_Node;
            Another_Node = another_Node;
            Weight = weight;
        }

        #endregion Constructors


        #region Properties

        public T A_Node { get; }


        public T Another_Node { get; }


        public string Label
        {
            get
            {
                return Weight.ToString();
            }
        }


        public int Weight { get; }

        #endregion Properties


        #region IEquatable_Implementation

        public bool Equals(IWeightedEdgeE<T> other)
        {
            return LabeledEdgeE<T>.Equals(this, other);
            /*return ((A_Node.Equals(other.A_Node) && Another_Node.Equals(other.Another_Node)) ||
                   (A_Node.Equals(other.Another_Node) && Another_Node.Equals(other.A_Node))) &&
                   Weight.Equals(other.Weight);*/
        }

        public bool Equals(WeightedEdgeE<T> other)
        {
            return Equals(other as IWeightedEdgeE<T>);
        }

        public bool Equals(ILabeledEdgeE<T> other)
        {
            return Equals(other as IWeightedEdgeE<T>);
        }

        public bool Equals(IEdgeE<T> other)
        {
            return Equals(other as IWeightedEdgeE<T>);
        }

        #endregion IEquatable_Implementation

    }
}