using Infrastructure.Repositories;
using Infrastructure.Data;
using Domain.Entities.Sample;

namespace Infrastructure.Repositories.Sample
{
    public class CollectionRepository : Repository<Collection>
    {
        public CollectionRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        // additional methods for domain-specific operations
    }
}