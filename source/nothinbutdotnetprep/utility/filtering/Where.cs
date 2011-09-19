using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class Where<ItemToFilter>
    {
        public static Func<ItemToFilter, PropertyType> has_a<PropertyType>(Func<ItemToFilter, PropertyType> accessor)
        {
            return accessor;
        }
    }
}