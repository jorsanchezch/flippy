using Infrastructure.Data;
using Domain.Entities.Sample;
using Domain.Repositories.Sample;

namespace Infrastructure.Repositories.Sample
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}