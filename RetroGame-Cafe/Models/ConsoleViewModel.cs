using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RetroGame_Cafe.Models
{
    public class ConsoleViewModel
    {
        [DisplayName("Identifiant")]
        public int Id { get; set; }
        [DisplayName("Console")]
        [MaxLength(50)]
        public required string Name { get; set; }
    }
}
