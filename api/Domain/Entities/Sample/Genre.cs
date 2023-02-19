using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Sample
{
    public class Genre : PocoEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Sound> Sounds { get; set; }
    }
}
