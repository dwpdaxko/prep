namespace nothinbutdotnetprep.utility.filtering
{
    public interface IProvideAccessToCreateMatchers<ItemToMatch, PropertyType>
    {
        IMatchA<ItemToMatch> create_using(IMatchA<PropertyType> matcher);
    }
}