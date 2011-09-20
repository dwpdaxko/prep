using System.Collections.Generic;
using nothinbutdotnetprep.utility.filtering;

namespace nothinbutdotnetprep.utility
{
    public static class EnumerableExtensions
    {
        public static Something for_sorting<ItemToSort>(this IEnumerable<ItemToSort> items)
        {
            
        }

        public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
                yield return item;
        }

        public static IEnumerable<ItemToMatch> all_items_matching<ItemToMatch>(this IEnumerable<ItemToMatch> items,
                                                                               Condition<ItemToMatch> criteria)
        {
            foreach (var item in items)
            {
                if (criteria(item))
                    yield return item;
            }
        }

        public static IEnumerable<ItemToMatch> all_items_matching<ItemToMatch>(this IEnumerable<ItemToMatch> items,
                                                                               IMatchA<ItemToMatch> criteria)
        {
            return items.all_items_matching(criteria.matches);
        }

        public static IEnumerable<T> sort_using<T>(this IEnumerable<T> items,
                                                   IComparer<T> comparer)
        {
            var sorted = new List<T>(items);
            sorted.Sort(comparer);
            return sorted;
        }
    }
}