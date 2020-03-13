using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Equatable
{
    public class DirectedEdgeE<T> : EdgeE<T>, IDirectedEdgeE<T>, IEquatable<DirectedEdgeE<T>> where T : IEquatable<T>
    {
        public DirectedEdgeE(T source, T target) : base(source, target)
        {
            Source = source;
            Target = target;
        }



        // interface IDirected
        public T Source { get; }

        public T Target { get; }

        public bool Equals(IDirectedEdgeE<T> other)
        {
            return Source.Equals(other.Source) && Target.Equals(other.Target);
        }

        // interface IEquatablel
        public bool Equals(DirectedEdgeE<T> other)
        {
            return Equals(other);
        }

        public override int GetHashCode()
        {
            var hashCode = -600697818;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Source.GetHashCode();
            hashCode = hashCode * -1521134295 + Target.GetHashCode();
            return hashCode;
        }
    }
}
