using Application.Requests.Sample;
using Application.Responses.Sample;

namespace Application.Services.Sample
{
    public interface ISoundService
    {
        Task<SoundResponse> GetSoundByIdAsync(int id);
        Task<SoundResponse> AddSoundAsync(SoundRequest request);
        Task<SoundResponse> UpdateSoundAsync(UpdateSoundRequest request);
        Task DeleteSoundAsync(int id);
        Task<IEnumerable<SoundResponse>> GetAllSoundsAsync();
    }

}
