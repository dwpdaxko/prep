using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public class AnonymousMatchBuilder<ItemToFilter, PropertyType>
    {
        readonly Func<ItemToFilter, PropertyType> accessor;

        public AnonymousMatchBuilder(Func<ItemToFilter, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public IMatchA<ItemToFilter> equal_to(PropertyType property)
        {
            return new AnonymousMatch<ItemToFilter>(x => accessor(x).Equals(property));
        }
    }
}