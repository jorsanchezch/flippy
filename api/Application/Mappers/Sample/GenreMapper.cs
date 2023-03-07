using Domain.Entities.Sample;
using Application.Requests.Sample;
using Application.Requests;
using Application.Responses.Sample;

namespace Application.Mappers.Sample
{
    public class GenreMapper : Mapper<Genre, GenreRequest, GenreResponse>
    {
        public override Genre Map(GenreRequest request)
        {
            return new Genre
            {
                Name = request.Name
            };
        }

        public override GenreResponse ToResponse(Genre entity)
        {
            return new GenreResponse
            {
                Name = entity.Name
            };
        }

        // Can make method overrides for additional Request versions.
    }
}
