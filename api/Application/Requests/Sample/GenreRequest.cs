using Domain.Entities.Sample;
using Application.Validators.Sample;

namespace Application.Requests.Sample
{
    public class GenreRequest : IRequest
    {
        public string Name { get; set; }
    }
}