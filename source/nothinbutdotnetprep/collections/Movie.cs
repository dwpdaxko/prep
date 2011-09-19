using System;

namespace nothinbutdotnetprep.collections
{
  public class Movie : IComparable
  {
    public string title { get; set; }
    public ProductionStudio production_studio { get; set; }
    public Genre genre { get; set; }
    public int rating { get; set; }
    public DateTime date_published { get; set; }S
      public int CompareTo(object obj)
      {
          throw new NotImplementedException();
      }
  }
}