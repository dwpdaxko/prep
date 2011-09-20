using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class OrderExtensionPoint<ItemToSort>
    {
        IEnumerable<ItemToSort> items;

        public OrderExtensionPoint(IEnumerable<ItemToSort> items)
        {
            this.items = items;
        }

        public SortedEnumerable<ItemToSort> by_descending<PropertyType>(Func<ItemToSort, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
        {
            return new SortedEnumerable<ItemToSort>(items, Order<ItemToSort>.by_descending(accessor));
        }

        public SortedEnumerable<ItemToSort> by<PropertyType>(Func<ItemToSort, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
        {
            return new SortedEnumerable<ItemToSort>(items, Order<ItemToSort>.by(accessor));
        }

        public SortedEnumerable<ItemToSort> by<PropertyType>(Func<ItemToSort, PropertyType> accessor, params PropertyType[] rankings)
        {
            return new SortedEnumerable<ItemToSort>(items, Order<ItemToSort>.by(accessor, rankings));
        }
    }
}