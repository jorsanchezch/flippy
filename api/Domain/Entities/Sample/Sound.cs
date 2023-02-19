using Domain.ValueObjects.Sample;
using Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Sample
{
    public class Sound : PocoEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
        [Required]
        public int Bpm { get; set; }
        [Required]
        public string AudioUri { get; set; }
        public Key Key { get; set; }
        public ICollection<Instrument> Instruments { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<User> Users { get; set;}
    }
}
