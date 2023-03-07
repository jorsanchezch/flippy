namespace Domain.Repositories
{
    public interface IFileRepository
    {
        Task<IFormFile> GetAsync(string name);
        Task<string> AddAsync(IFormFile file);
        Task UpdateAsync(IFormFile file);
        Task DeleteAsync(string name);
        Task<IEnumerable<IFormFile>> GetAllAsync();
    }
}
