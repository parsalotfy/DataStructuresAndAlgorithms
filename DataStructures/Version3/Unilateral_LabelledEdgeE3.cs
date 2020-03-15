using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3
{
    public class Unilateral_LabelledEdgeE3<T> : Unilateral_EdgeE3<T>, ILabelledEdgeE3, IEquatable<Unilateral_LabelledEdgeE3<T>> where T : IEquatable<T>
    {
        public Unilateral_LabelledEdgeE3(T source, T target, string label) : base(source, target)
        {
            Label = label;
        }


        public string Label { get; }


        public bool Equals(Unilateral_LabelledEdgeE3<T> other)
        {
            return base.Equals(other) && (Label == other.Label);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Label.GetHashCode();
        }

    }
}
