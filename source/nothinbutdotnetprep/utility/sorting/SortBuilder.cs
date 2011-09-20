using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class SortBuilder<ItemToSort>
    {
        IComparer<ItemToSort> comparer;

        public SortBuilder(IComparer<ItemToSort> comparer)
        {
            this.comparer = comparer;
        }

        public void then_by<PropertyType>(Func<ItemToSort, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
        {
            comparer = comparer.then_by(accessor);
        }

        public void then_by<PropertyType>(Func<ItemToSort, PropertyType> accessor, params PropertyType[] values)
        {
            comparer = comparer.then_by(accessor, values);
        }

        public void then_by_descending<PropertyType>(Func<ItemToSort, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
        {
            comparer = comparer.then_by_descending(accessor);
        }

        public IComparer<ItemToSort> build()
        {
            return comparer;
        }
    }
}