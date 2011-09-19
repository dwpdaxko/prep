namespace nothinbutdotnetprep.utility.filtering
{
    public interface ICreateMatchers<ItemToFilter, PropertyType>
    {
        IMatchA<ItemToFilter> equal_to(PropertyType value);
        IMatchA<ItemToFilter> equal_to_any(params PropertyType[] values);
        IMatchA<ItemToFilter> not_equal_to(PropertyType value);
    }
}