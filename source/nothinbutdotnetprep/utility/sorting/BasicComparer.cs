using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class BasicComparer<ItemToSort, PropertyType> : IComparer<ItemToSort> 
        where PropertyType : IComparable<PropertyType>
    {
        readonly Func<ItemToSort, PropertyType> accessor;

        public BasicComparer(Func<ItemToSort, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            return accessor(x).CompareTo(accessor(y));
        }
    }
}