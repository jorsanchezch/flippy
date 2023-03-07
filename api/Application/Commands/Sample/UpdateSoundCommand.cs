using Application.Requests.Sample;

namespace Application.Commands.Sample
{
    public class UpdateSoundCommand : ICommand
    {
        public UpdateSoundRequest request { get; set; }
    }
}