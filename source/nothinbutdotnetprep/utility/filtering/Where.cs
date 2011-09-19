using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class Where<ItemToFilter>
    {
        public static ComparableMatchFactory<ItemToFilter, PropertyType> has_an<PropertyType>(
            Func<ItemToFilter, PropertyType> accessor)
            where PropertyType : IComparable<PropertyType>
        {
            return new ComparableMatchFactory<ItemToFilter, PropertyType>(has_a(accessor));
                
        }

        public static MatchFactory<ItemToFilter, PropertyType> has_a<PropertyType>(Func<ItemToFilter, PropertyType> accessor)
        {
            return new MatchFactory<ItemToFilter, PropertyType>(accessor);
        }
    }
}