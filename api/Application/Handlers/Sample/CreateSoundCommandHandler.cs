using Application.Commands.Sample;
using Domain.Repositories.Sample;
using Domain.Repositories;
using Application.Responses.Sample;
using Application.Validators.Sample;
using Application.Mappers.Sample;
using FluentValidation;
using Common.Utils;

namespace Application.Handlers.Sample
{
    public class CreateSoundCommandHandler : ICommandHandler<CreateSoundCommand, SoundResponse>
    {
        private readonly ISoundRepository _soundRepository;
        private readonly IFileRepository _fileRepository;

        public CreateSoundCommandHandler(ISoundRepository soundRepository,
                                        IFileRepository fileRepository                            
            )
        {
            _soundRepository = soundRepository;
            _fileRepository = fileRepository;
        }

        public async Task<SoundResponse> Handle(CreateSoundCommand command)
        {
            var validator = new CreateSoundValidator();
            var request = command.request;
            var mapper = new SoundMapper();

            validator.Validate(request, true);

            var sound = mapper.Map(request);

            string path = await _fileRepository.AddAsync(request.AudioFile);
            sound.AudioUrl = path;

            await _soundRepository.AddAsync(sound);

            return mapper.ToResponse(sound);
        }
    }
}