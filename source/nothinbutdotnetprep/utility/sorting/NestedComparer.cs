using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class NestedComparer<ItemToSort, PropertyType> : IComparer<ItemToSort>
    {
        readonly IComparer<ItemToSort> first;
        readonly IComparer<ItemToSort> second;

        public NestedComparer(IComparer<ItemToSort> first,
                               IComparer<ItemToSort> second)
        {
            this.first = first;
            this.second = second;
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            var result = first.Compare(x, y);
            if (result == 0)
                result = second.Compare(x, y);
            return result;
        }
    }
}