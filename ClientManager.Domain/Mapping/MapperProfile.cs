using AutoMapper;
using ClientManager.Data.Entities;
using ClientManager.Domain.Models;

namespace ClientManager.Domain.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ClientEntity, ClientModel>();
            CreateMap<ClientModel, ClientEntity>();
        }               
    }
}
