using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.utility.filtering
{
    public class MatchFactory<ItemToFilter, PropertyType>
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
            return new AnonymousMatch<ItemToFilter>(x => new List<PropertyType>(values).Contains(accessor(x)));
        }

        public IMatchA<ItemToFilter> not_equal_to(PropertyType value)
        {
            throw new NotImplementedException();
        }
    }
}