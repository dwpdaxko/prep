using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.specs
{
    public class DateComparer : IComparer<DateTime>
    {
        public int Compare(DateTime x, DateTime y)
        {
            return x.CompareTo(y);
        }
    }
}