using ClientManager.Data.Entities;
using ClientManager.Data.Contexts;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var existing = GetClientById(client.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(client);
            }

            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            //var client = new ClientEntity() {Id = id};

            //_context.Attach(client);
            //_context.Remove(client);

            _context.Users.Remove(_context.Users.Find(id));           
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
