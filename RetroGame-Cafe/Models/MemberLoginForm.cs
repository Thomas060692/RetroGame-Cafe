using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RetroGame_Cafe.Models
{
    public class MemberLoginForm
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email")]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe")]
        public required string Password { get; set; }
    }
}
