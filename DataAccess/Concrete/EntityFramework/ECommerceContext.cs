using Entites.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ECommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ECommerce;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductColor>()
                .HasKey(pc => new { pc.ProductId, pc.ColorId });
            modelBuilder.Entity<ProductColor>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductColors)
                .HasForeignKey(pc => pc.ProductId);
            modelBuilder.Entity<ProductColor>()
                .HasOne(pc => pc.Color)
                .WithMany(c => c.ProductColors)
                .HasForeignKey(pc => pc.ColorId);

            modelBuilder.Entity<ProductSubCategory>()
                .HasKey(ps => new { ps.ProductId, ps.SubCategoryId });
            modelBuilder.Entity<ProductSubCategory>()
                .HasOne(ps => ps.Product)
                .WithMany(p => p.ProductSubCategories)
                .HasForeignKey(ps => ps.ProductId);
            modelBuilder.Entity<ProductSubCategory>()
                .HasOne(ps => ps.SubCategory)
                .WithMany(s => s.ProductSubCategories)
                .HasForeignKey(ps => ps.SubCategoryId);

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
//PokemennOwner -> Pokemon -> (PokemonCategories-> Category, Reviews-> Review, Reviewer) , Owner