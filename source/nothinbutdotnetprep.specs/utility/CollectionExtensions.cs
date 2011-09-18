using System.Collections.Generic;

namespace nothinbutdotnetprep.specs.utility
{
  public static class CollectionExtensions
  {
    public static void add_all<T>(this IList<T> list, params T[] Items)
    {
      foreach (var t in Items) list.Add(t);
    }
  }
}