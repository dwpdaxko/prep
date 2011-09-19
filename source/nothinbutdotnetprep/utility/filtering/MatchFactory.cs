using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public class MatchFactory<ItemToFilter, PropertyType> : ICreateMatchers<ItemToFilter, PropertyType>
    {
        Func<ItemToFilter, PropertyType> accessor;

        public MatchFactory(Func<ItemToFilter, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public IMatchA<ItemToFilter> equal_to(PropertyType value)
        {
            return equal_to_any(value);
        }

        public IMatchA<ItemToFilter> equal_to_any(params PropertyType[] values)
        {
            return create_using(new EqualToAny<PropertyType>(values));
        }

        public IMatchA<ItemToFilter> create_using(IMatchA<PropertyType> real_condition)
        {
            return new PropertyMatch<ItemToFilter, PropertyType>(accessor,
                                                                 real_condition);
        }

        public IMatchA<ItemToFilter> not_equal_to(PropertyType value)
        {
            return equal_to_any(value).not();
        }

        public IMatchA<ItemToFilter> create_using(Condition<ItemToFilter> condition)
        {
            return new AnonymousMatch<ItemToFilter>(condition);
        }
    }
}