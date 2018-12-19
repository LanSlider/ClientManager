using ClientManager.Data.Entities;
using Data.Contexts;
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

        public void Create(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void Update(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            //_context.Clients.Remove(_context.Clients.Find(id));
            var client = new Client() {Id = id};

            _context.Attach(client);
            _context.Remove(client);
            _context.SaveChanges();

        }

        public ICollection<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.Find(id);
        }
    }
}
