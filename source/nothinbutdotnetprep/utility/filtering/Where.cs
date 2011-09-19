using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nothinbutdotnetprep.utility.filtering
{

	public delegate object FieldSpec<TItem>(TItem item);

	public static class Where<TItem>
	{
		public static Matcher<TItem> has_a(FieldSpec<TItem> spec)
		{
			return new Matcher<TItem>(spec);
		}
	}

	public class Matcher<TItem>
	{
		private FieldSpec<TItem> left_side;

		public Matcher(FieldSpec<TItem> value)
		{
			left_side = value;
		}

		public Condition<TItem> equal_to(object val)
		{
			return item => left_side(item) == val;
		}
	}
}
