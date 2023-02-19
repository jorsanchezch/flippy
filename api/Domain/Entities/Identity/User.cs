using Domain.Entities.Sample;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Identity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public ICollection<Sound> Sounds { get; set; }
    }
}