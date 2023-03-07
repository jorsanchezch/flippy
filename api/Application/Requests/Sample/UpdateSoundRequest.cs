using Domain.Entities.Sample;
using Application.Validators.Sample;

namespace Application.Requests.Sample
{
    public class UpdateSoundRequest : SoundRequest
    {
        public int Id { get; set; }
    }
}