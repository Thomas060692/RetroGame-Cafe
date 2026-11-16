namespace RetroGame_Cafe.DAL.Entities
{
    public class ProductEntity
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public bool IsVegie { get; set; }

        public int Fk_Categorie_Id { get; set; }
        public CategorieEntity Categorie { get; set; } = null!;

    }
}
