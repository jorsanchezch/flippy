using Application.Handlers;
using Application.Commands.Sample;
using Domain.Repositories.Sample;
using Domain.Entities.Sample;
using Application.Responses.Sample;
using Application.Validators.Sample;
using FluentValidation;
using Domain.Repositories;
using Application.Mappers.Sample;

namespace Application.Handlers.Sample
{
    public class UpdateSoundCommandHandler : ICommandHandler<UpdateSoundCommand, SoundResponse>
    {
        private readonly ISoundRepository _soundRepository;
        private readonly IFileRepository _fileRepository;

        public UpdateSoundCommandHandler(ISoundRepository soundRepository,
                                        IFileRepository fileRepository
            )
        {
            _soundRepository = soundRepository;
            _fileRepository = fileRepository;
        }

        public async Task<SoundResponse> Handle(UpdateSoundCommand command)
        {
            var validator = new UpdateSoundValidator();
            var sound = command.request;
            var mapper = new SoundMapper();

            validator.Validate(sound, true);
            var instance = mapper.Map(sound);

            await _soundRepository.AddAsync(new Sound());

            return mapper.ToResponse(instance);
        }
    }
}