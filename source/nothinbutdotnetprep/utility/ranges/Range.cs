using System;

namespace nothinbutdotnetprep.utility.ranges
{
    public interface Range<T>  where T : IComparable<T>
    {
        bool contains(T value);
    }
}