using System;

namespace DataStructures.Version3
{
    public class BilateralEdgeE3<T> : UnilateralEdgeE3<T>, IEquatable<BilateralEdgeE3<T>> where T : IEquatable<T>
    {
        public BilateralEdgeE3(T source, T target) : base(source, target)
        {
        }

        public bool Equals(BilateralEdgeE3<T> other)
        {
            return base.Equals(other) || (Source.Equals(other.Target) && Target.Equals(other.Source));
        }

        public override int GetHashCode()
        {
            return Source.GetHashCode() ^ Target.GetHashCode();
        }
    }
}
