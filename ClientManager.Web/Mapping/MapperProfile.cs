using AutoMapper;
using ClientManager.Domain.Models;
using ClientManager.Web.Models;

namespace ClientManager.Web.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ClientModel, ClientViewModel>();
            CreateMap<ClientViewModel, ClientModel>();
        }
    }
}
