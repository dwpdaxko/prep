using System.Collections.Generic;
using nothinbutdotnetprep.utility.filtering;
using nothinbutdotnetprep.utility.sorting;
using System.Linq;

namespace nothinbutdotnetprep.utility
{
    public static class EnumerableExtensions
    {
        public static OrderExtensionPoint<ItemToSort> sort<ItemToSort>(this IEnumerable<ItemToSort> items)
        {
            return new OrderExtensionPoint<ItemToSort>(items);
        }

        public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
        {
            return items.all_items_matching(x => true);
        }

        public static IEnumerable<ItemToMatch> all_items_matching<ItemToMatch>(this IEnumerable<ItemToMatch> items,
                                                                               Condition<ItemToMatch> criteria)
        {
            return items.Where(criteria.Invoke);
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