using AutoMapper;
using ClientManager.Data.Entities;
using ClientManager.Web.Models;

namespace ClientManager.Web.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ClientEntity, ClientViewModel>();
            CreateMap<ClientViewModel, ClientEntity>();
        }
    }
}
