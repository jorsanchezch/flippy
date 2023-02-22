using Application.Requests.Sample;

namespace Application.Commands.Sample
{
    public class UpdateGenreCommand : ICommand
    {
        public UpdateGenreRequest request { get; set; }
    }
}