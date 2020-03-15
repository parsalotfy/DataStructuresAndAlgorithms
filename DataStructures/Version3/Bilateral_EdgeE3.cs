using System;

namespace DataStructures.Version3
{
    public class Bilateral_EdgeE3<T> : Unilateral_EdgeE3<T>, IEquatable<Bilateral_EdgeE3<T>> where T : IEquatable<T>
    {
        public Bilateral_EdgeE3(T source, T target) : base(source, target)
        {
        }

        public bool Equals(Bilateral_EdgeE3<T> other)
        {
            return base.Equals(other) || (Source.Equals(other.Target) && Target.Equals(other.Source));
        }

        public override int GetHashCode()
        {
            return Source.GetHashCode() ^ Target.GetHashCode();
        }
    }
}
