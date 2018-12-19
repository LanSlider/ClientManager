using System.Collections.Generic;
using ClientManager.Data.Repositories;
using ClientManager.Domain.Models;

namespace ClientManager.Domain.Services
{
    internal class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Create(ClientModel client)
        {
            _clientRepository.Create(client);
        }

        public void Update(ClientModel client)
        {
            _clientRepository.Update(client);
        }

        public void DeleteById(int id)
        {
            _clientRepository.DeleteById(id);            
        }

        public ICollection<ClientModel> GetClients()
        {
            return _clientRepository.GetClients();
        }

        public ClientModel GetClientById(int id)
        {
            return _clientRepository.GetClientById(id);
        }
    }
}
