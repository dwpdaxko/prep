namespace nothinbutdotnetprep.utility.filtering
{
    public class OrMatch<Item> : IMatchA<Item>
    {
        IMatchA<Item> left_side;
        IMatchA<Item> right_side;

        public OrMatch(IMatchA<Item> left_side, IMatchA<Item> right_side)
        {
            this.left_side = left_side;
            this.right_side = right_side;
        }

        public bool matches(Item item)
        {
            return left_side.matches(item) || right_side.matches(item);
        }
    }
}