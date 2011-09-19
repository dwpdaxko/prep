using System;
using System.Collections.Generic;
using nothinbutdotnetprep.collections;

namespace nothinbutdotnetprep.specifications
{
    public class PublisherSpecification : ISpecification<Movie>
    {
        public readonly ProductionStudio production_studio;

        public PublisherSpecification(ProductionStudio production_studio)
        {
            this.production_studio = production_studio;
        }

        public bool IsSatisfiedBy(Movie entity)
        {
            return entity.production_studio == production_studio;
        }
    }
}
