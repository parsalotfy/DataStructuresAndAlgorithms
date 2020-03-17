using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3_MoreInterface
{
    public class Unilateral_WeightedEdgeE3<T> : Unilateral_LabelledEdgeE3<T>, IWeightedEdgeE3, IEquatable<Unilateral_WeightedEdgeE3<T>> where T : IEquatable<T>
    {
        public Unilateral_WeightedEdgeE3(T source, T target, int weight) : base(source, target, weight.ToString())
        {
            Weight = weight;
        }

        public int Weight { get; }

        public bool Equals(Unilateral_WeightedEdgeE3<T> other)
        {
            return base.Equals(other);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
