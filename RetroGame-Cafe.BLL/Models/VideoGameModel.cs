namespace RetroGame_Cafe.BLL.Models
{
    public class VideoGameModel
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required int ConsoleId { get; set; }
    }
}
