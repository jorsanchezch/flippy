using Application.Handlers;
using Application.Commands.Sample;
using Domain.Repositories.Sample;
using Domain.Entities.Sample;
using Application.Responses.Sample;
using Application.Validators.Sample;
using FluentValidation;
using Application.Mappers.Sample;

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
            var mapper = new GenreMapper();

            Genre instance = mapper.Map(genre);

            validator.Validate(genre, true);

            await _genreRepository.AddAsync(new Genre());

            return mapper.ToResponse(instance);
        }
    }
}