using Application.Requests.Sample;

namespace Application.Commands.Sample
{
    public class CreateGenreCommand : ICommand
    {
        public GenreRequest request { get; set; }
    }
}