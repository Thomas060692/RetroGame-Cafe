using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RetroGame_Cafe.Models
{
    public class VideoGameViewModel
    {
        [DisplayName("Identifiant")]
        public required int Id { get; set; }
        [DisplayName("Titre")]
        [MaxLength(75)]
        public required string Title { get; set; }
        [DisplayName("Identifiant console")]
        public required int ConsoleId { get; set; }
        [DisplayName("Console")]
        public required string ConsoleName { get; set; }
    }
}
