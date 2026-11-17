using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Configs
{
    public class ConsoleConfig : IEntityTypeConfiguration<ConsoleEntity>
    {
        public void Configure(EntityTypeBuilder<ConsoleEntity> builder)
        {
            builder.ToTable("Consoles");

            builder.HasKey(c => c.Id)
                   .IsClustered();

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                   .HasMaxLength(50)
                   .IsRequired();
        }
    }
}
