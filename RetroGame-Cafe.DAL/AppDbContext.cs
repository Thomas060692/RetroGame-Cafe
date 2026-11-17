using Microsoft.EntityFrameworkCore;
using RetroGame_Cafe.DAL.Configs;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ConsoleEntity> Consoles { get; set; }
        public DbSet<VideoGameEntity> VideoGames { get; set; }
        public DbSet<CategorieEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<MemberEntity> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new ConsoleConfig());
            modelBuilder.ApplyConfiguration(new VideoGameConfig());
            modelBuilder.ApplyConfiguration(new CategorieConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new MemberConfig());
        }
    }
}
