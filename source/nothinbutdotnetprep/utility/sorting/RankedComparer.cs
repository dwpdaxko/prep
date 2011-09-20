using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class RankedComparer<ItemToSort, PropertyType> : IComparer<ItemToSort>
    {
        readonly Func<ItemToSort, PropertyType> accessor;
        readonly bool @descending;
        readonly PropertyType[] ranked_items;
        Dictionary<PropertyType, int> rank_map;

        public RankedComparer(
            Func<ItemToSort, PropertyType> accessor, 
            params PropertyType[] ranked_items)
        {
            this.accessor = accessor;
            this.ranked_items = ranked_items;
        }

        int rank_of(PropertyType item)
        {
            if (rank_map == null)
                build_rank_map();
            return rank_map[item];
        }

        void build_rank_map()
        {
            rank_map = new Dictionary<PropertyType, int>();
            var i = 0;
            foreach (var item in ranked_items)
            {
                rank_map.Add(item, i++);
            }
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            return rank_of(accessor(x)).CompareTo(rank_of(accessor(y)));
        }
    }
}