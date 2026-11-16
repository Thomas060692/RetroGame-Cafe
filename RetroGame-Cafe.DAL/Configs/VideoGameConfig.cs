using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Configs
{
    public class VideoGameConfig : IEntityTypeConfiguration<VideoGameEntity>
    {
        public void Configure(EntityTypeBuilder<VideoGameEntity> builder)
        {
            builder.ToTable("VideoGames");

            builder.HasKey(v => v.Id)
                   .IsClustered();

            builder.Property(v => v.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(v => v.Title)
                   .HasMaxLength(75)
                   .IsRequired();

            builder.HasOne(v => v.Console)
                   .WithOne()
                   .HasPrincipalKey<ConsoleEntity>(c => c.Id)
                   .IsRequired();
        }
    }
}
