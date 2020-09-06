using Microsoft.EntityFrameworkCore;
using ToysNGames.API.Models;

namespace ToysNGames.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Product> Products {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasIndex(u => u.Id)
                .IsUnique();
        } 
    }
}