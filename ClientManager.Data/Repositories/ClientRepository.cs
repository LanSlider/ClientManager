using ClientManager.Data.Entities;
using ClientManager.Data.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace ClientManager.Data.Repositories
{
    internal class ClientRepository : IClientRepository
    {
        private readonly ClientDbContext _context;

        public ClientRepository(ClientDbContext context)
        {
            _context = context;
        }

        public void Create(ClientEntity client)
        {
            _context.Users.Add(client);
            _context.SaveChanges();
        }

        public void Update(ClientEntity client)
        {
            _context.Users.Update(client);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            //_context.Clients.Remove(_context.Clients.Find(id));
            var client = new ClientEntity() {Id = id};

            _context.Attach(client);
            _context.Remove(client);
            _context.SaveChanges();

        }

        public ICollection<ClientEntity> GetClients()
        {
            return _context.Users.ToList();
        }

        public ClientEntity GetClientById(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
