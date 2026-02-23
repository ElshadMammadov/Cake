using Cake.Models;
using Microsoft.EntityFrameworkCore;

namespace Cake.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPreview> ProductPreviews { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> option): base(option) { }
    }
}
