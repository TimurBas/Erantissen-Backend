using Erantissen_Backend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Erantissen_Backend.Data.Contexts
{
    public class Context: DbContext
    {
        public DbSet<ProductDto> Products { get; set; }
        public DbSet<HeroDto> Hero { get; set; }
        public DbSet<MostBoughtProductDto> MostBoughtProducts { get; set; }
        public DbSet<CategoryDto> Categories { get; set; }
        public DbSet<SubcategoryDto> Subcategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.DbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var products = builder.Entity<ProductDto>().ToTable("Products");
            products.HasKey(p => p.Title);
            products
                .HasOne(p => p.Subcategory)
                .WithMany(sc => sc.Products)
                .HasForeignKey(p => p.SubcategoryTitle)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<HeroDto>().ToTable("Hero").HasKey(h => h.Id);

            var mbps = builder.Entity<MostBoughtProductDto>().ToTable("MostBoughtProducts");
            mbps.HasKey(mbp => mbp.Title);
            mbps.HasOne(mbp => mbp.Subcategory)
                .WithMany(sc => sc.MostBoughtProducts)
                .HasForeignKey(mbp => mbp.SubcategoryTitle)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CategoryDto>().ToTable("Categories").HasKey(c => c.Title);

            var subcategories = builder.Entity<SubcategoryDto>().ToTable("Subcategories");
            subcategories.HasKey(sc => sc.Title);
            subcategories
                .HasOne(sc => sc.Category)
                .WithMany(c => c.Subcategories)
                .HasForeignKey(sc => sc.CategoryTitle)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
