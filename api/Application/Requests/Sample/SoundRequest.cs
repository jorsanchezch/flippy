using Domain.ValueObjects.Sample;

namespace Application.Requests.Sample
{
    public class SoundRequest : IRequest
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Bpm { get; set; }
        public int? CollectionId { get; set; }
        public IFormFile AudioFile { get; set; }
        public string KeyRoot { get; set; }
        public string KeyMod { get; set; }
        public string KeyForm { get; set; }
    }
}