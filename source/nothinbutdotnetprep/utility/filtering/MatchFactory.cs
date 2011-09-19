using System;

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
            return new AnonymousMatch<ItemToFilter>(x => accessor(x).Equals(value));
        }

        public IMatchA<ItemToFilter> equal_to_any(params PropertyType[] values)
        {
            throw new NotImplementedException();
        }
    }
}