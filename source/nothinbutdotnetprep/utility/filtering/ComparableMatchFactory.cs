using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public class ComparableMatchFactory<ItemToFilter, PropertyType> : ICreateMatchers<ItemToFilter,PropertyType> where PropertyType : IComparable<PropertyType>
    {
        Func<ItemToFilter, PropertyType> accessor;
        ICreateMatchers<ItemToFilter, PropertyType> original;

        public ComparableMatchFactory(Func<ItemToFilter, PropertyType> accessor, ICreateMatchers<ItemToFilter, PropertyType> original)
        {
            this.accessor = accessor;
            this.original = original;
        }

        public IMatchA<ItemToFilter> greater_than(PropertyType value)
        {
            return new AnonymousMatch<ItemToFilter>(x => accessor(x).CompareTo(value) > 0);
        }

        public IMatchA<ItemToFilter> less_than(PropertyType value)
        {
            return new NegatingMatch<ItemToFilter>(greater_than(value).or(equal_to(value)));
        }


        public IMatchA<ItemToFilter> between(PropertyType start,PropertyType end)
        {
            return new OrMatch<ItemToFilter>(greater_than(start).or(equal_to(start)), less_than(end).or(equal_to(end)));
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