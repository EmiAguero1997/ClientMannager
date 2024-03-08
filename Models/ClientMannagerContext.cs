using Microsoft.EntityFrameworkCore;
namespace ClientMannager.Models
{
    public class ClientMannagerContext : DbContext
    {
        public ClientMannagerContext(DbContextOptions<ClientMannagerContext> options) : base(options) { }

        //dbsets
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}