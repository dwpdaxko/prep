using System;
using nothinbutdotnetprep.utility.ranges;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class MatchExtensions
    {
        public static IMatchA<ItemToFilter> greater_than<ItemToFilter, PropertyType>(this ICreateMatchers<ItemToFilter, PropertyType> match_creater, PropertyType value)
            where PropertyType : IComparable<PropertyType>
        {
            return match_creater.create_using(new IsGreaterThan<PropertyType>(value));
        }

        public static IMatchA<ItemToFilter> between<ItemToFilter, PropertyType>(this ICreateMatchers<ItemToFilter, PropertyType> match_creater, PropertyType start, PropertyType end)
            where PropertyType : IComparable<PropertyType>
        {
            return match_creater.create_using(new FallsInRange<PropertyType>(
                                                  new InclusiveRange<PropertyType>(start, end)));
        }
    }
}