using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.sorting
{
    public class RankedComparer<PropertyType> : IComparer<PropertyType>
    {
        IList<PropertyType> rankings;

        public RankedComparer(params PropertyType[] ranked_items)
        {
            this.rankings = new List<PropertyType>(ranked_items);
        }

        public int Compare(PropertyType x, PropertyType y)
        {
            return rankings.IndexOf(x).CompareTo(rankings.IndexOf(y));
        }
    }
}