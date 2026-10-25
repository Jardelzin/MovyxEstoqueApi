using Microsoft.EntityFrameworkCore;
using MovyxEstoque.Api.Models;

namespace MovyxEstoque.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<StockBalance> StockBalances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite primary key for the join table
            modelBuilder.Entity<StockBalance>()
                .HasKey(sb => new { sb.ProductId, sb.PeriodId });

            base.OnModelCreating(modelBuilder);
        }
    }
}