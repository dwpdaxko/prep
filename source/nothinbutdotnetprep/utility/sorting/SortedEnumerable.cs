using System;
using System.Collections;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class SortedEnumerable<ItemToSort> : IEnumerable<ItemToSort>
    {
        IEnumerable<ItemToSort> items;
        SortBuilder<ItemToSort> builder;

        public SortedEnumerable(IEnumerable<ItemToSort> items, SortBuilder<ItemToSort> builder)
        {
            this.items = items;
            this.builder = builder;
        }

        public SortedEnumerable<ItemToSort> then_by_descending<PropertyType>(Func<ItemToSort, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
        {
            builder.then_by_descending(accessor);
            return this;
        }

        public SortedEnumerable<ItemToSort> then_by<PropertyType>(Func<ItemToSort, PropertyType> accessor)
            where PropertyType : IComparable<PropertyType>
        {
            builder.then_by(accessor);
            return this;
        }

        public SortedEnumerable<ItemToSort> then_by<PropertyType>(Func<ItemToSort, PropertyType> accessor, params PropertyType[] rankings)
        {
            builder.then_by(accessor, rankings);
            return this;
        }

        public IEnumerator<ItemToSort> GetEnumerator()
        {
            var list = new List<ItemToSort>(items);
            list.Sort(builder.build());
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}