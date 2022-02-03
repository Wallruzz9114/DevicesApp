using System.ComponentModel.DataAnnotations;
using Models.Abstract;

namespace Models.Entities
{
    public class AppUser : BaseEntity
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}