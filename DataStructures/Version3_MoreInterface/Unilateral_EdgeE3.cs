using System;

namespace DataStructures.Version3_MoreInterface
{
    // One-Way
    public class Unilateral_EdgeE3<T> : IEdgeE3<T>, IEquatable<Unilateral_EdgeE3<T>> where T : IEquatable<T>
    {
        #region Constructors

        public Unilateral_EdgeE3(T source, T target)
        {
            Source = source;
            Target = target;
        }

        #endregion Constructors


        #region Properties

        public T Source { get; }


        public T Target { get; }


        #endregion Properties



        #region IEquatable_Implementation

        public bool Equals(Unilateral_EdgeE3<T> other)
        {
            return Source.Equals(other.Source) && Target.Equals(other.Target);
        }

        public override int GetHashCode()
        {
            int hashCode = -600697818;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Source.GetHashCode();
            hashCode = hashCode * -1521134295 + Target.GetHashCode();
            return hashCode;
        }


        #endregion IEquatable_Implementation
    }
}
