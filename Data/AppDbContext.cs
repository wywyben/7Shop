using ASP.NET_CA_SEVEN_SHOP.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_CA_SEVEN_SHOP.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSets
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
    }
}