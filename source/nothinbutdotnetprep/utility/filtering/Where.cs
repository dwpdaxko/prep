using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class Where<ItemToFilter>
    {
        public static MatchingExtensionPoint<ItemToFilter, PropertyType> has_a<PropertyType>(Func<ItemToFilter, PropertyType> accessor)
        {
            return new MatchingExtensionPoint<ItemToFilter, PropertyType>(accessor);
        }
    }
}