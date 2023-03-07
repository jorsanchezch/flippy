using Domain.Repositories.Sample;
using Infrastructure.Data;
using Domain.Entities.Sample;

namespace Infrastructure.Repositories.Sample
{
    public class SoundRepository : Repository<Sound>, ISoundRepository
    {
        public SoundRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        // additional methods for domain-specific operations
    }
}