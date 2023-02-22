using Domain.Entities.Sample;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Identity
{
    public class User : IdentityUser, IEntity
    {
        public ICollection<Sound> Sounds { get; set; }
    }
}