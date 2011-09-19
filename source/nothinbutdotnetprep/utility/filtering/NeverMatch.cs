namespace nothinbutdotnetprep.utility.filtering
{
    public class NeverMatch<Item> : IMatchA<Item>
    {
        public bool matches(Item item)
        {
            return false;
        }
    }
}