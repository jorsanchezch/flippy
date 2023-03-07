using Application.Requests.Sample;

namespace Application.Commands.Sample
{
    public class CreateSoundCommand : ICommand
    {
        public SoundRequest request { get; set; }
    }
}