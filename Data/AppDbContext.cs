using HaMyDuyen_2122110528.Model;
using Microsoft.EntityFrameworkCore;

namespace HaMyDuyen_2122110528.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 

    }
}
