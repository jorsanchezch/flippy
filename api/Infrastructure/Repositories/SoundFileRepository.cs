using Domain.Repositories;
using Microsoft.Extensions.FileProviders;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class SoundFileRepository : IFileRepository
    {
        private readonly string _directory = "..\\Infrastructure\\Storage\\Samples";

        public async Task<IFormFile> GetAsync(string url)
        {
            var files = await GetAllAsync();
            var file = files.Where(f => f.FileName.Contains(url)).FirstOrDefault();

            return file;
        }

        public async Task<string> GetPath(string url)
        {
            return Path.Combine(_directory, url);
        }

        public async Task<string> AddAsync(IFormFile file)
        {
            var filePath = Path.Combine(_directory, file.FileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);

            }

            return filePath;
        }
        public async Task UpdateAsync(IFormFile file)
        {
            await DeleteAsync(file.FileName);
            await AddAsync(file);
        }

        public async Task DeleteAsync(string name)
        {
            var file = await GetAsync(name);
            if (file == null)
                return;

            var filePath = Path.Combine(_directory, file.FileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public async Task<IEnumerable<IFormFile>> GetAllAsync()
        {
            var files = Directory.GetFiles(_directory)
                .Select(f => new PhysicalFileProvider(_directory).GetFileInfo(f).PhysicalPath)
                .Select(f => new FileInfo(f))
                .Select(f => (IFormFile)new FormFile(new MemoryStream(File.ReadAllBytes(f.FullName)), 0, f.Length, f.Name, f.Name));

            return files;
        }
    }
}
