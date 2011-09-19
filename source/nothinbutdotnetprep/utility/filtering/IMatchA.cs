namespace nothinbutdotnetprep.utility.filtering
{
    public interface IMatchA<Item>
    {
        bool matches(Item item);
    }
}