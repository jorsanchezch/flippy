using Application.Mappers.Sample;
using Application.Responses.Sample;
using Domain.Repositories.Sample;

namespace Application.Queries.Sample
{
    public class GetSoundsQuery : IQuery
    {
        private readonly ISoundRepository _repo;

        public GetSoundsQuery(ISoundRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<SoundResponse>> Execute()
        {
            return (new SoundMapper())
                .ToResponse(await _repo.GetAllAsync());
        }
    }
}