using Application.Commands.Sample;
using Domain.Repositories.Sample;
using Application.Responses.Sample;
using Application.Validators.Sample;
using Application.Mappers.Sample;
using FluentValidation;

namespace Application.Handlers.Sample
{
    public class CreateGenreCommandHandler : ICommandHandler<CreateGenreCommand, GenreResponse>
    {
        private readonly IGenreRepository _genreRepository;

        public CreateGenreCommandHandler(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<GenreResponse> Handle(CreateGenreCommand command)
        {
            var validator = new CreateGenreValidator();
            var request = command.request;
            var mapper = new GenreMapper();

            validator.Validate(request, true);


            var genre = mapper.Map(request);

            await _genreRepository.AddAsync(genre);

            return mapper.ToResponse(genre);
        }
    }
}