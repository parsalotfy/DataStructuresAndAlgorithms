using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version2
{
    // Two-Way
    public class BilateralEdgeE2<T> : UnilateralEdgeE2<T>, IEdgeE2<T>, IEquatable<BilateralEdgeE2<T>> where T : IEquatable<T>
    {
        public BilateralEdgeE2(T source, T target) : base(source, target)
        {
            
        }

        public bool Equals(IEdgeE2<T> other)
        {
            return base.Equals(other) || (Source.Equals(other.Target) && Target.Equals(other.Source));
        }

        public bool Equals(BilateralEdgeE2<T> other)
        {
            return Equals(other as IEdgeE2<T>);
        }



        public override int GetHashCode()
        {
            return Source.GetHashCode() ^ Target.GetHashCode();
        }
    }
}
