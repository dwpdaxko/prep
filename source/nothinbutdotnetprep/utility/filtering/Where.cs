using System;
using nothinbutdotnetprep.collections;

namespace nothinbutdotnetprep.utility.filtering
{

    public static class Where<TItem>
    {
        public static Func<Movie,ProductionStudio> has_a(Func<Movie,ProductionStudio> studio_accessor)
        {
            return studio_accessor;
        }
    }

    public static class WhereExtensions
    {
        public static IMatchA<Movie> equal_to(this Func<Movie, ProductionStudio> accessor,ProductionStudio studio)
        {
            return new AnonymousMatch<Movie>(x => x.production_studio == studio);
        }
    }
}