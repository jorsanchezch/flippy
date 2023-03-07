using Domain.ValueObjects.Sample;

namespace Application.Responses.Sample
{
    public class SoundResponse : Response
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Bpm { get; set; }
        public int? CollectionId {  get; set; }
        public string KeyRoot { get; set; }
        public string KeyMod { get; set; }
        public string KeyForm { get; set; }
        public byte[] AudioFile { get; set; }
    }
}
