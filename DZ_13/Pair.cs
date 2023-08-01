using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_13
{
    public class Pair<S, T>
    {
        public Pair(S first, T second)
        {
            First = first;
            Second = second;
        }

        public S First { get; }
        public T Second { get; }
    }

    public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        public ComparablePair(T first, U second)
        {
            First = first;
            Second = second;
        }
        public T First { get; }
        public U Second { get; }

        public int CompareTo(ComparablePair<T, U> other)
        {
            if (other == null) return 1;
            int compareFirst = First.CompareTo(other.First);
            if (compareFirst != 0) return compareFirst;
            int compareSecond = Second.CompareTo(other.Second);
            return compareSecond;
        }
    }
}