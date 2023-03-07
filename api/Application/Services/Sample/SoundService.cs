using Domain.Repositories.Sample;
using Application.Requests.Sample;
using Application.Commands.Sample;
using Application.Handlers.Sample;
using Domain.Repositories;
using Application.Responses.Sample;
using Application.Mappers.Sample;
using Application.Queries.Sample;

namespace Application.Services.Sample
{
    public class SoundService : ISoundService
    {
        protected readonly ISoundRepository _repo;
        protected readonly IFileRepository _fileRepo;

        public SoundService(ISoundRepository repo, IFileRepository fileRepo)
        {
            _repo = repo;
            _fileRepo = fileRepo;
        }

        public async Task<SoundResponse> GetSoundByIdAsync(int id)
        {
            var entity = await _repo.GetByIdAsync(id);

            if (entity == null)
            {
                return null;
            }

            return (new SoundMapper()).ToResponse(entity);
        }

        public async Task<IEnumerable<SoundResponse>> GetAllSoundsAsync()
        {
            return await (new GetSoundsQuery(_repo)).Execute();
        }

        public async Task<SoundResponse> AddSoundAsync(SoundRequest request)
        {
            var command = new CreateSoundCommand
            {
                request = request
            };

            var handler = new CreateSoundCommandHandler(_repo, _fileRepo);

            return await handler.Handle(command); ;
        }

        public async Task<SoundResponse> UpdateSoundAsync(UpdateSoundRequest request)
        {
            var command = new UpdateSoundCommand
            {
                request = request
            };

            var handler = new UpdateSoundCommandHandler(_repo, _fileRepo);

            return await handler.Handle(command); ;
        }

        public async Task DeleteSoundAsync(int id)
        {
            var sound = await _repo.GetByIdAsync(id);
            if (sound != null)
            {
                await _repo.DeleteAsync(sound);
            }
        }
    }
}
