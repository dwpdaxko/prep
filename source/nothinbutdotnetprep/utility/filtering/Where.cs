using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class Where<ItemToFilter>
    {
        public static AnonymousMatchBuilder<ItemToFilter, PropertyType> has_a<PropertyType>(Func<ItemToFilter, PropertyType> accessor)
        {
            return new AnonymousMatchBuilder<ItemToFilter, PropertyType>(accessor);
        }
    }
}