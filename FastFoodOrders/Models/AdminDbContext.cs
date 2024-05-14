using Microsoft.EntityFrameworkCore;

namespace FastFoodOrders.Models
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Order> Orders { get; set; }

        
    }
}
