namespace RetroGame_Cafe.BLL.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsVegie { get; set; }
        public int CategorieId { get; set; }
        public string CategorieName { get; set; } = null!;
    }
}
