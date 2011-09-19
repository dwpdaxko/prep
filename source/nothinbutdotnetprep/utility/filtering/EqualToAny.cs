using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.filtering
{
    public class EqualToAny<T> : IMatchA<T>
    {
        IList<T> values;

        public EqualToAny(params T[] values)
        {
            this.values = new List<T>(values);
        }

        public bool matches(T item)
        {
            return values.Contains(item);
        }
    }
}