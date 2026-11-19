using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RetroGame_Cafe.Models
{
    public class ProductViewModel
    {
        [DisplayName("Identifiant")]
        public required int Id { get; set; }
        [DisplayName("Produit")]
        public required string Name { get; set; }
        [DisplayName("Description")]
        public required string Description { get; set; }
        [DisplayName("Prix")]
        [DataType(DataType.Currency)]
        public required decimal Price { get; set; }
        [DisplayName("Plat végatarien")]
        public required bool IsVegie { get; set; }
        [DisplayName("Numero de catégorie")]
        public required int CategorieId { get; set; }
        [DisplayName("Catégorie")]
        public required string CategorieName { get; set; } = null!;
    }
}
