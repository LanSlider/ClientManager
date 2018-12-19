using System.Collections.Generic;
using ClientManager.Domain.Models;

namespace ClientManager.Domain.Services
{
    public interface IClientService
    {
        void Create(ClientModel client);
        void Update(ClientModel client);
        void DeleteById(int id);
        ICollection<ClientModel> GetClients();
        ClientModel GetClientById(int id);
    }
}
