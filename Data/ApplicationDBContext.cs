using System.Linq;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Stocks
            modelBuilder.Entity<Stock>().HasData(
                new Stock { Id = 1, Symbol = "AAPL", CompanyName = "Apple Inc.", Purchase = 145.30M, LastDiv = 0.22M, Industry = "Technology", MarketCap = 2250000000000 },
                new Stock { Id = 2, Symbol = "GOOGL", CompanyName = "Alphabet Inc.", Purchase = 2735.13M, LastDiv = 0M, Industry = "Technology", MarketCap = 1820000000000 }
            );

            // Seed data for Comments
            modelBuilder.Entity<Comment>().HasData(
                new Comment { Id = 1, Title = "Great Stock", Content = "Apple has been performing really well.", CreatedOn = DateTime.UtcNow, StockId = 1 },
                new Comment { Id = 2, Title = "Solid Performance", Content = "Google continues to innovate.", CreatedOn = DateTime.UtcNow, StockId = 2 }
            );
        }
    }
}
