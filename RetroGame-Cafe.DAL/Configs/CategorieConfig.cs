using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Configs
{
    public class CategorieConfig : IEntityTypeConfiguration<CategorieEntity>
    {
        public void Configure(EntityTypeBuilder<CategorieEntity> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id)
                   .IsClustered();

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                   .HasMaxLength(50)
                   .IsRequired();
        }
    }
}
