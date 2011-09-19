using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class Where<ItemToFilter>
    {
        public static MatchFactory<ItemToFilter, PropertyType> has_a<PropertyType>(Func<ItemToFilter, PropertyType> accessor)
        {
            return new MatchFactory<ItemToFilter, PropertyType>(accessor);
        }
    }
}