using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class TEqualityComparer<T> : EqualityComparer<T>
    {
        private TEqualityComparer()
        {

        }

        public TEqualityComparer(Func<T,T,bool> equalsMethod, Func<T, int> getHashCodeMethod)
        {
            EqualsMethod=equalsMethod;
            GetHashCodeMethod=getHashCodeMethod;
        }

        public Func<T,T,bool> EqualsMethod { get; }
        public Func<T, int> GetHashCodeMethod { get; }


        public override bool Equals(T x, T y)
        {
            return EqualsMethod(x,y);
        }

        public override int GetHashCode(T t)
        {
            return GetHashCodeMethod(t);
        }
    }
}