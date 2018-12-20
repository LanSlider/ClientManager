using System.Collections.Generic;
using ClientManager.Data.Entities;

namespace ClientManager.Domain.Services
{
    public interface IClientService
    {
        void Create(ClientEntity client);
        void Update(ClientEntity client);
        void DeleteById(int id);
        ICollection<ClientEntity> GetClients();
        ClientEntity GetClientById(int id);
    }
}
