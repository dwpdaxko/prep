using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class PropertyComparer<ItemToSort,PropertyType> : IComparer<ItemToSort>
    {
        Func<ItemToSort, PropertyType> accessor;
        IComparer<PropertyType> actual_comparer;

        public PropertyComparer(Func<ItemToSort, PropertyType> accessor, IComparer<PropertyType> actual_comparer)
        {
            this.accessor = accessor;
            this.actual_comparer = actual_comparer;
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            return actual_comparer.Compare(accessor(x), accessor(y)); 
        }
    }
}