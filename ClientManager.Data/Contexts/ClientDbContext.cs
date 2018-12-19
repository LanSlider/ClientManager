using ClientManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClientManager.Data.Contexts
{
    public class ClientDbContext : DbContext
    {
        public DbSet<ClientEntity> Clients { get; set; }

        public ClientDbContext(DbContextOptions<ClientDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
