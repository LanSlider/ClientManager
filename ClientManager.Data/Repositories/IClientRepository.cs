using ClientManager.Data.Entities;
using System.Collections.Generic;

namespace ClientManager.Data.Repositories
{
    public interface IClientRepository
    {
        void Create(ClientEntity client);
        void Update(ClientEntity client);
        void DeleteById(int id);
        ICollection<ClientEntity> GetClients();
        ClientEntity GetClientById(int id);
    }
}
