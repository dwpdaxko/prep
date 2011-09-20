using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public static class OrderExtensions
    {
        public static IComparer<ItemToSort> then_by<ItemToSort, PropertyType>(this IComparer<ItemToSort> comparer, Func<ItemToSort, PropertyType> accessor)
            where PropertyType : IComparable<PropertyType>
        {
            return new ChainedComparer<ItemToSort, PropertyType>(comparer, Order<ItemToSort>.by(accessor));
        }

        public static IComparer<ItemToSort> then_by<ItemToSort, PropertyType>(this IComparer<ItemToSort> comparer, Func<ItemToSort, PropertyType> accessor,params PropertyType[] values)
        {
            return new ChainedComparer<ItemToSort, PropertyType>(comparer, Order<ItemToSort>.by(accessor,values));
        }

        public static IComparer<ItemToSort> then_by_descending<ItemToSort, PropertyType>(this IComparer<ItemToSort> comparer, Func<ItemToSort, PropertyType> accessor)
            where PropertyType : IComparable<PropertyType>
        {
            return new ChainedComparer<ItemToSort, PropertyType>(comparer, Order<ItemToSort>.by_descending(accessor));
        }
    }
}