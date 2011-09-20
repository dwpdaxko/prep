using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public static class OrderExtensions
    {
        public static IComparer<ItemToSort> then_by<ItemToSort, PropertyType>(this IComparer<ItemToSort> comparer, Func<ItemToSort, PropertyType> accessor)
            where PropertyType : IComparable<PropertyType>
        {
            return new NestedComparer<ItemToSort, PropertyType>(comparer, new BasicComparer<ItemToSort, PropertyType>(accessor));
        }
    }
}