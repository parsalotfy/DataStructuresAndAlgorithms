using System;

namespace DataStructures.Version2
{
    // One-Way
    public class UnilateralEdgeE2<T> : IEdgeE2<T>, IEquatable<UnilateralEdgeE2<T>> where T : IEquatable<T>
    {
        #region Constructors

        public UnilateralEdgeE2(T source, T target)
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

        public bool Equals(IEdgeE2<T> other)
        {
            return Source.Equals(other.Source) && Target.Equals(other.Target);
        }



        public bool Equals(UnilateralEdgeE2<T> other)
        {
            return Equals(other as IEdgeE2<T>);
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
