using ClientManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }


        public ClientDbContext(DbContextOptions<ClientDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
