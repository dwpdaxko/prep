namespace nothinbutdotnetprep.utility.filtering
{
	public class AnyMatch<Item> : IMatchA<Item>
	{
		private IMatchA<Item> _backer; 

		public void AddClause(IMatchA<Item> clause)
		{
			if (_backer == null)
			{
				_backer = clause;
			}
			else
			{
				_backer = new OrMatch<Item>(_backer, clause);
			}
		}

		public bool matches(Item item)
		{
			return _backer.matches(item);
		}
	}
}