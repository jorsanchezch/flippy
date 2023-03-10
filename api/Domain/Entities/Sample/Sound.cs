using Domain.ValueObjects.Sample;
using Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Sample
{
    public class Sound : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public int Bpm { get; set; }
        [Required]
        public string AudioUrl { get; set; }
        public int? CollectionId { get; set; }
        public Key Key { get; set; }
        public Collection Collection { get; set; }
        public ICollection<Instrument> Instruments { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<User> Users { get; set;}
    }
}
