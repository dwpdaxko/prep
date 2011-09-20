using System;
using System.Collections;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class SortedEnumerable<ItemToSort> : IEnumerable<ItemToSort>
    {
        IEnumerable<ItemToSort> items;
        IComparer<ItemToSort> comparer;

        public SortedEnumerable(IEnumerable<ItemToSort> items, IComparer<ItemToSort> comparer)
        {
            this.items = items;
            this.comparer = comparer;
        }

        public SortedEnumerable<ItemToSort> then_by_descending<PropertyType>(Func<ItemToSort, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
        {
            return new SortedEnumerable<ItemToSort>(items,comparer.then_by_descending(accessor));
        }

        public SortedEnumerable<ItemToSort> then_by<PropertyType>(Func<ItemToSort, PropertyType> accessor)
            where PropertyType : IComparable<PropertyType>
        {
            return new SortedEnumerable<ItemToSort>(items,comparer.then_by(accessor));
        }

        public SortedEnumerable<ItemToSort> then_by<PropertyType>(Func<ItemToSort, PropertyType> accessor, params PropertyType[] rankings)
        {
            return new SortedEnumerable<ItemToSort>(items,comparer.then_by(accessor,rankings));
        }

        public IEnumerator<ItemToSort> GetEnumerator()
        {
            return items.sort_using(comparer).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}