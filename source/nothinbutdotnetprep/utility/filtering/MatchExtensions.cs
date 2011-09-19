using System;
using nothinbutdotnetprep.utility.ranges;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class MatchExtensions
    {
        public static IMatchA<ItemToFilter> equal_to<ItemToFilter,PropertyType>(this IProvideAccessToCreateMatchers<ItemToFilter,PropertyType> extension_point,PropertyType value)
        {
            return equal_to_any(extension_point,value);
        }

        public static IMatchA<ItemToFilter> equal_to_any<ItemToFilter,PropertyType>(this IProvideAccessToCreateMatchers<ItemToFilter,PropertyType> extension_point,params PropertyType[] values)
        {
            return create_using(extension_point, new EqualToAny<PropertyType>(values));
        }

        public static IMatchA<ItemToFilter> create_using<ItemToFilter,PropertyType>(this IProvideAccessToCreateMatchers<ItemToFilter,PropertyType> extension_point,IMatchA<PropertyType> real_condition)
        {
            return extension_point.create_using(real_condition);
        }

        public static IMatchA<ItemToFilter> greater_than<ItemToFilter, PropertyType>(this IProvideAccessToCreateMatchers<ItemToFilter, PropertyType> extension_point, PropertyType value)
            where PropertyType : IComparable<PropertyType>
        {
            return create_using(extension_point, new IsGreaterThan<PropertyType>(value));
        }

        public static IMatchA<ItemToFilter> between<ItemToFilter, PropertyType>(this IProvideAccessToCreateMatchers<ItemToFilter, PropertyType> extension_point, PropertyType start, PropertyType end)
            where PropertyType : IComparable<PropertyType>
        {
            return create_using(extension_point, new FallsInRange<PropertyType>(
                                                  new InclusiveRange<PropertyType>(start, end)));
        }
    }
}