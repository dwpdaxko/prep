using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class ReversedComparer<ItemToSort> : IComparer<ItemToSort>
    {
        readonly IComparer<ItemToSort> comparer;

        public ReversedComparer(IComparer<ItemToSort> comparer)
        {
            this.comparer = comparer;
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            return comparer.Compare(x, y) * -1;
        }
    }
}