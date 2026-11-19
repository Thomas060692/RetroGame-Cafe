using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id)
                   .IsClustered();

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(p => p.Description)
                   .HasMaxLength(150);

            builder.Property(p => p.Price)
                   .HasPrecision(10, 2)
                   .IsRequired();

            builder.Property(p => p.IsVegie)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.HasOne(p => p.Categorie)
                   .WithMany()
                   .HasForeignKey(c => c.Fk_Categorie_Id)
                   .IsRequired();
        }
    }
}
