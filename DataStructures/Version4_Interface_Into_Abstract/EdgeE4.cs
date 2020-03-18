using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version4_Interface_Into_Abstract
{
    public abstract class EdgeE4<T> where T : IEquatable<T>
    {
        public T Source { get; }
        public T Target { get; }
    }
}
