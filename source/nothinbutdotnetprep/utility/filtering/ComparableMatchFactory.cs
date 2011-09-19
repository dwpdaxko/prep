using System;
using nothinbutdotnetprep.utility.ranges;

namespace nothinbutdotnetprep.utility.filtering
{
    public class ComparableMatchFactory<ItemToFilter, PropertyType> : ICreateMatchers<ItemToFilter,PropertyType> where PropertyType : IComparable<PropertyType>
    {
        ICreateMatchers<ItemToFilter, PropertyType> original;

        public ComparableMatchFactory(ICreateMatchers<ItemToFilter, PropertyType> original)
        {
            this.original = original;
        }

        public IMatchA<ItemToFilter> greater_than(PropertyType value)
        {
            return original.create_using(new IsGreaterThan<PropertyType>(value));
        }

        public IMatchA<ItemToFilter> between(PropertyType start,PropertyType end)
        {
            return original.create_using(new FallsInRange<PropertyType>(
                new InclusiveRange<PropertyType>(start, end)));
        }

        public IMatchA<ItemToFilter> create_using(Condition<ItemToFilter> condition)
        {
            return original.create_using(condition);
        }

        public IMatchA<ItemToFilter> create_using(IMatchA<PropertyType> real_condition)
        {
            return original.create_using(real_condition);
        }

        public IMatchA<ItemToFilter> less_than(PropertyType value)
        {
            return new NegatingMatch<ItemToFilter>(greater_than(value).or(equal_to(value)));
        }

        public IMatchA<ItemToFilter> equal_to(PropertyType value)
        {
            return original.equal_to(value);
        }

        public IMatchA<ItemToFilter> equal_to_any(params PropertyType[] values)
        {
            return original.equal_to_any(values);
        }

        public IMatchA<ItemToFilter> not_equal_to(PropertyType value)
        {
            return original.not_equal_to(value);
        }
    }
}