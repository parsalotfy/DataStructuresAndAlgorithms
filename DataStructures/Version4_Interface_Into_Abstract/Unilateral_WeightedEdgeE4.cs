using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version4_Interface_Into_Abstract
{
    public class Unilateral_WeightedEdgeE4<T> : Unilateral_LabelledEdgeE4<T>, IWeightedEdgeE4, IEquatable<Unilateral_WeightedEdgeE4<T>> where T : IEquatable<T>
    {
        public Unilateral_WeightedEdgeE4(T source, T target, int weight) : base(source, target, weight.ToString())
        {
            Weight = weight;
        }

        public int Weight { get; }

        public bool Equals(Unilateral_WeightedEdgeE4<T> other)
        {
            return base.Equals(other);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
