namespace RetroGame_Cafe.DAL.Entities
{
    public class VideoGameEntity
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required int FK_Console_Id { get; set; }
        public ConsoleEntity Console { get; set; } = null!;
    }
}
