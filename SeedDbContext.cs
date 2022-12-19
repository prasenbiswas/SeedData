using Microsoft.EntityFrameworkCore;

namespace SeedDataPrac1.Models
{
    public class SeedDbContext : DbContext
    {
        public SeedDbContext(DbContextOptions<SeedDbContext> options) : base(options)
        {

        }
        public DbSet<SeedData> seedDatas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SeedData>().HasData(
                new SeedData() { SeedId = 1, Name = "Prasen", Gender = "Male", Age = 24 },
                new SeedData() { SeedId = 2, Name = "Biswas", Gender = "Male", Age = 25 }
                );
        }
    }
}