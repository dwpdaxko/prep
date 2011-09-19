using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public class ComparableMatchFactory<ItemToFilter, PropertyType> where PropertyType : IComparable<PropertyType>
    {
        Func<ItemToFilter, PropertyType> accessor;

        public ComparableMatchFactory(Func<ItemToFilter, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public IMatchA<ItemToFilter> greater_than(PropertyType value)
        {
            return new AnonymousMatch<ItemToFilter>(x => accessor(x).CompareTo(value) > 0);
        }

        public IMatchA<ItemToFilter> less_than(PropertyType value)
        {
            return new NegatingMatch<ItemToFilter>(new OrMatch<ItemToFilter>(greater_than(value), equal(value)));
        }

        public IMatchA<ItemToFilter> not_equal(PropertyType value)
        {
            return new NegatingMatch<ItemToFilter>(equal(value));
        }

        public IMatchA<ItemToFilter> equal(PropertyType value)
        {
            return new AnonymousMatch<ItemToFilter>(x => accessor(x).CompareTo(value) == 0);
        }

        public IMatchA<ItemToFilter> between(PropertyType start,PropertyType end)
        {
            return new OrMatch<ItemToFilter>(greater_than(start), less_than(end));
        }



    }
}