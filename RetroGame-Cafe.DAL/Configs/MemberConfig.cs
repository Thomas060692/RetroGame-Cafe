using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Configs
{
    public class MemberConfig : IEntityTypeConfiguration<MemberEntity>
    {
        public void Configure(EntityTypeBuilder<MemberEntity> builder)
        {
            builder.ToTable("Members");

            builder.HasKey(m => m.Id)
                   .IsClustered();

            builder.Property(m => m.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(m => m.FristName)
                   .HasMaxLength(50);

            builder.Property(m => m.LastName)
                   .HasMaxLength(50);

            builder.Property(m => m.Email)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(m => m.Pseudo)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(m => m.PasswordHash)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(m => m.Role)
                   .HasMaxLength(50);

            builder.HasIndex(m => m.Email)
                   .IsUnique();

            builder.HasIndex(m => m.Pseudo)
                   .IsUnique();
        }
    }
}
