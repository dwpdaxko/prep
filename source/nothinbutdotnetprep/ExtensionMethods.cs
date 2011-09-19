namespace nothinbutdotnetprep
{
    public static class ExtensionMethods
    {
        public static ISpecification<TEntity> And<TEntity>(this ISpecification<TEntity> s1, ISpecification<TEntity> s2)
        {
            return new AndSpecification<TEntity>(s1, s2);
        }

        public static ISpecification<TEntity> Or<TEntity>(this ISpecification<TEntity> s1, ISpecification<TEntity> s2)
        {
            return new OrSpecification<TEntity>(s1, s2);
        }

        public static ISpecification<TEntity> Not<TEntity>(this ISpecification<TEntity> s)
        {
            return new NotSpecification<TEntity>(s);
        }
    }
}
