using Microsoft.EntityFrameworkCore;
using ASP.NET_CA_SEVEN_SHOP.Models;

namespace ASP.NET_CA_SEVEN_SHOP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductsModel> Products { get; set; }
    }
}
