using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class FilteringExtensions
    {
        public static IMatchA<ItemToFilter> equal_to<ItemToFilter, PropertyType>(
            this Func<ItemToFilter, PropertyType> accessor, PropertyType value)
        {
            return new AnonymousMatch<ItemToFilter>(x => accessor(x).Equals(value));
        }
    }
}