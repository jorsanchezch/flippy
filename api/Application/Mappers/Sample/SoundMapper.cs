using Domain.Entities.Sample;
using Application.Requests.Sample;
using Domain.ValueObjects.Sample;
using Common.Utils;
using Application.Responses.Sample;

namespace Application.Mappers.Sample
{
    public class SoundMapper : Mapper<Sound, SoundRequest, SoundResponse>
    {
        public override Sound Map(SoundRequest request)
        {
            return new Sound
            {
                Name = request.Name,
                Description = request.Description,
                Bpm = request.Bpm,
                CollectionId = request.CollectionId,
                Key = new Key
                {
                    Root = Utils.Parse<Note>(request.KeyRoot),
                    Mod = Utils.Parse<Modification>(request.KeyMod),
                    Form = Utils.Parse<Form>(request.KeyForm)
                }
            };
        }

        public override SoundResponse ToResponse(Sound entity)
        {
            return new SoundResponse
            {
                Name = entity.Name,
                Description = entity.Description,
                Bpm = entity.Bpm,
                CollectionId = entity.CollectionId,
                KeyRoot = entity.Key.Root.ToString(),
                KeyMod = entity.Key.Mod.ToString(),
                KeyForm = entity.Key.Form.ToString(),
                AudioFile = Utils.GetFileBytes(entity.AudioUrl)
            };
        }

        // Can make method overrides for additional Request versions.
    }
}
