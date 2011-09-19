namespace nothinbutdotnetprep.utility.filtering
{
    public class AnonymousMatch<ItemToMatch> : IMatchA<ItemToMatch>
    {
        Condition<ItemToMatch> condition;

        public AnonymousMatch(Condition<ItemToMatch> condition)
        {
            this.condition = condition;
        }

        public bool matches(ItemToMatch item)
        {
            return condition(item);
        }
    }
}