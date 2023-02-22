using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Sample
{
    [Index(nameof(Instrument.Name), IsUnique = true)]
    public class Instrument : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Sound> Sounds { get; set; }
    }
}
