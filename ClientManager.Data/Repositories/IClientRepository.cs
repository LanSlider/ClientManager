using System.Collections;
using System.Collections.Generic;

namespace ClientManager.Data.Repositories
{
    public interface IClientRepository
    {
        void Create(Client client);
        void Update(Client client);
        void DeleteById(int id);
        ICollection<Client> GetClients();
        Client GetClientById(int id);
    }
}
