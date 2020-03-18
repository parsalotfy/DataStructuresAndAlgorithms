using System;

namespace DataStructures.Version4_Interface_Into_Abstract
{
    public class Bilateral_EdgeE4<T> : Unilateral_EdgeE4<T>, IEquatable<Bilateral_EdgeE4<T>> where T : IEquatable<T>
    {
        public Bilateral_EdgeE4(T source, T target) : base(source, target)
        {
        }

        public bool Equals(Bilateral_EdgeE4<T> other)
        {
            return base.Equals(other) || (Source.Equals(other.Target) && Target.Equals(other.Source));
        }

        public override int GetHashCode()
        {
            return Source.GetHashCode() ^ Target.GetHashCode();
        }
    }
}
