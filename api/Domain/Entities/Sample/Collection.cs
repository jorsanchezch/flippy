using Domain.ValueObjects.Sample;
using Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Sample
{
    public class Collection: IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Sound> Sounds { get; set; }
    }
}
