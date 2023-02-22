using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Sample
{
    [Index(nameof(Genre.Name), IsUnique = true)]
    public class Genre : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Sound> Sounds { get; set; }
    }
}
