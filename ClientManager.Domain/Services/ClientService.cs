using AutoMapper;
using ClientManager.Data.Entities;
using ClientManager.Data.Repositories;
using ClientManager.Domain.Models;
using System.Collections.Generic;

namespace ClientManager.Domain.Services
{
    internal class ClientService : IClientService
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
        }

        public void Create(ClientModel client)
        {
            var clientModel = _mapper.Map<ClientEntity>(client);
            _clientRepository.Create(clientModel);
        }

        public void Update(ClientModel client)
        {
            var clientEntity = _mapper.Map<ClientEntity>(client);
            _clientRepository.Update(clientEntity);
        }

        public void DeleteById(int id)
        {
            _clientRepository.DeleteById(id);            
        }

        public ICollection<ClientModel> GetClients()
        {
            var clientList = _clientRepository.GetClients();

            return _mapper.Map<ICollection<ClientModel>>(clientList);
        }

        public ClientModel GetClientById(int id)
        {
            var clientEntity = _clientRepository.GetClientById(id);

            return _mapper.Map<ClientModel>(clientEntity);
        }
    }
}
