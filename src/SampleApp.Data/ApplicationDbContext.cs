using Microsoft.EntityFrameworkCore;
using SampleApp.Domain;

namespace SampleApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // uncomment this code below to enable LazyLoading
            // optionsBuilder.UseLazyLoadingProxies();
        }

        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Product
            modelBuilder.Entity<Product>().ToTable("PRODUCT");
            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id).HasName("PK_PRODUCT");
            modelBuilder.Entity<Product>().Property(p => p.Id).HasColumnName("ID");
            modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("NAME")
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(p => p.Description).HasColumnName("DESCRIPTION")
                .HasMaxLength(1000);
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnName("PRICE")
                .IsRequired()
                .HasColumnType("DECIMAL(38,8)");
            modelBuilder.Entity<Product>().Property(p => p.StockQuantity)
                .HasColumnName("STOCK_QUANTITY")
                .IsRequired()
                .HasColumnType("INT")
                .HasDefaultValue(0);
            modelBuilder.Entity<Product>().Property(p => p.CategoryId)
                .HasColumnName("CATEGORY_ID")
                .IsRequired(false);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.CategoryId)
                .HasConstraintName("FK_PRODUCTS_CATEGORIES_CATEGORY_ID");

            //Category
            modelBuilder.Entity<Category>().ToTable("CATEGORY")
                .HasKey(p => p.Id).HasName("PK_CATEGORY");
            modelBuilder.Entity<Category>().Property(p => p.Id).HasColumnName("ID");
            modelBuilder.Entity<Category>().Property(p => p.Name).HasColumnName("NAME")
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Category>().Property(p => p.Description).HasColumnName("DESCRIPTION")
                .HasMaxLength(1000);
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
