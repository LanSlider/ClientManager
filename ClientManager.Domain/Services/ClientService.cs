using AutoMapper;
using ClientManager.Data.Entities;
using ClientManager.Data.Repositories;
using System.Collections.Generic;

namespace ClientManager.Domain.Services
{
    internal class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Create(ClientEntity client)
        {
            _clientRepository.Create(client);
        }

        public void Update(ClientEntity client)
        {
            _clientRepository.Update(client);
        }

        public void DeleteById(int id)
        {
            _clientRepository.DeleteById(id);            
        }

        public ICollection<ClientEntity> GetClients()
        {          
            return _clientRepository.GetClients(); 
        }

        public ClientEntity GetClientById(int id)
        {
            return _clientRepository.GetClientById(id);
        }
    }
}
