using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public static class DateMatchingExtensions
    {
        public static IMatchA<ItemToMatch> greater_than<ItemToMatch>(
            this IProvideAccessToCreateMatchers<ItemToMatch, DateTime> extension_point,
            int year)
        {
            return extension_point.create_using(new YearOfDateIsGreaterThan(year)); 
        }
    }
}