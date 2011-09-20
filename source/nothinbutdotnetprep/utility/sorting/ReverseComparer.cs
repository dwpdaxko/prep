using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class ReverseComparer<ItemToSort> : IComparer<ItemToSort>
    {
        IComparer<ItemToSort> comparer;

        public ReverseComparer(IComparer<ItemToSort> comparer)
        {
            this.comparer = comparer;
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            return -comparer.Compare(x, y);
        }
    }
}