using Erantissen_Backend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Erantissen_Backend.Data.Contexts
{
    public class Context: DbContext
    {
        public DbSet<ProductDto> Products { get; set; }
        public DbSet<HeroDto> Hero { get; set; }
        public DbSet<MostBoughtProductDto> MostBoughtProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.DbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductDto>().ToTable("Products");
            builder.Entity<HeroDto>().ToTable("Hero");
            builder.Entity<MostBoughtProductDto>().ToTable("MostBoughtProducts");
        }
    }
}
