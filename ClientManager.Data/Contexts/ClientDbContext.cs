using ClientManager.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClientManager.Data.Contexts
{
    public class ClientDbContext : IdentityDbContext<ClientEntity, RoleEntity, int>
    {
        //public DbSet<ClientEntity> Clients { get; set; }

        public ClientDbContext(DbContextOptions<ClientDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
