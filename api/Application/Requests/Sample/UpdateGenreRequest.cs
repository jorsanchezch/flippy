using Domain.Entities.Sample;
using Application.Validators.Sample;

namespace Application.Requests.Sample
{
    public class UpdateGenreRequest : GenreRequest
    {
        public int Id { get; set; }
    }
}