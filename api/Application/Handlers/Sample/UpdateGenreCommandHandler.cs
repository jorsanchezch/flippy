using Application.Handlers;
using Application.Commands.Sample;
using Domain.Repositories.Sample;
using Domain.Entities.Sample;
using Application.Responses.Sample;
using Application.Validators.Sample;
using FluentValidation;

namespace Application.Handlers.Sample
{
    public class UpdateGenreCommandHandler : ICommandHandler<UpdateGenreCommand, GenreResponse>
    {
        private readonly IGenreRepository _genreRepository;

        public UpdateGenreCommandHandler(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<GenreResponse> Handle(UpdateGenreCommand command)
        {
            var validator = new UpdateGenreValidator();
            var genre = command.request;
            
            validator.Validate(genre, true);

            await _genreRepository.AddAsync(new Genre());

            return new GenreResponse
            {
                Name = genre.Name
            };
        }
    }
}