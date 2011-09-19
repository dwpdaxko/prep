using System;

namespace nothinbutdotnetprep.utility.ranges
{
    public class InclusiveRange<T> : Range<T> where T : IComparable<T>
    {
        T start;
        T end;

        public InclusiveRange(T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        public bool contains(T value)
        {
            return value.CompareTo(start) >= 0 && value.CompareTo(end) <= 0;
        }
    }
}