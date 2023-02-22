using Domain.Entities.Sample;
using Application.Requests.Sample;
using Application.Requests;

namespace Application.Mappers.Sample
{
    public class GenreMapper : IMapper<Genre, GenreRequest>
    {
        public Genre Map(GenreRequest request)
        {
            return new Genre
            {
                Name = request.Name
            };
        }

        // Can make method overrides for additional Request versions.
    }
}
