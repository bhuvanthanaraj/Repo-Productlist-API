using Microsoft.EntityFrameworkCore;
using saneforcetask1.Models;

namespace saneforcetask1.DataDbContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Trans> Transs { get; set; }

        public DbSet<AddTrans> AddTranss { get; set; }





    }
}
