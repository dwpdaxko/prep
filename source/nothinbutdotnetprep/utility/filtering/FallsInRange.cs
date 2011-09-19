using System;
using nothinbutdotnetprep.utility.ranges;

namespace nothinbutdotnetprep.utility.filtering
{
    public class FallsInRange<T> : IMatchA<T> where T : IComparable<T>
    {
       Range<T> range;

        public FallsInRange(Range<T> range)
        {
            this.range = range;
        }

        public bool matches(T item)
        {
            return range.contains(item);
        }
    }
}