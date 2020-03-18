using System;

namespace DataStructures.Version4_Interface_Into_Abstract
{
    public class Unilateral_LabelledEdgeE4<T> : Unilateral_EdgeE4<T>, ILabelledEdgeE4, IEquatable<Unilateral_LabelledEdgeE4<T>> where T : IEquatable<T>
    {
        public Unilateral_LabelledEdgeE4(T source, T target, string label) : base(source, target)
        {
            Label = label;
        }


        public string Label { get; }


        public bool Equals(Unilateral_LabelledEdgeE4<T> other)
        {
            return base.Equals(other) && (Label == other.Label);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Label.GetHashCode();
        }

    }
}
