using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public class MatchingExtensionPoint<ItemToMatch,PropertyType> : IProvideAccessToCreateMatchers<ItemToMatch, PropertyType>
    {
        Func<ItemToMatch, PropertyType> accessor; 

        public IProvideAccessToCreateMatchers<ItemToMatch,PropertyType> not
        {
            get
            {
                return new NegatingExtensionPoint<ItemToMatch, PropertyType>(this);
            }
        }

        public MatchingExtensionPoint(Func<ItemToMatch, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public IMatchA<ItemToMatch> create_using(IMatchA<PropertyType> matcher)
        {
            return new PropertyMatch<ItemToMatch, PropertyType>(accessor,
                                                                matcher);
        }
    }
}