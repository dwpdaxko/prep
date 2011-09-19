namespace nothinbutdotnetprep.utility.filtering
{
    public class NegatingExtensionPoint<ItemToMatch,PropertyType> : IProvideAccessToCreateMatchers<ItemToMatch,PropertyType>
    {
        IProvideAccessToCreateMatchers<ItemToMatch, PropertyType> original;

        public NegatingExtensionPoint(IProvideAccessToCreateMatchers<ItemToMatch, PropertyType> original)
        {
            this.original = original;
        }

        public IMatchA<ItemToMatch> create_using(IMatchA<PropertyType> matcher)
        {
            return original.create_using(matcher).not();
        }
    }
}