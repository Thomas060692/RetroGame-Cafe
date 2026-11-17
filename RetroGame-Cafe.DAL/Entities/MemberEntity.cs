namespace RetroGame_Cafe.DAL.Entities
{
    public class MemberEntity
    {
        public int Id { get; set; }
        public string? FristName { get; set; }
        public string? LastName { get; set; }
        public required string Email { get; set; }
        public required string Pseudo { get; set; }
        public required string PasswordHash { get; set; }
        public string Role { get; set; } = null!;
    }
}
