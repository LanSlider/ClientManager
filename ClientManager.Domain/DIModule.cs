using Autofac;
using ClientManager.Domain.Services;
using Module = System.Reflection.Module;

namespace ClientManager.Domain
{
    public class DIModule : Module
    {
        public static void Load(ContainerBuilder builder)
        {            
            builder.RegisterType<ClientService>().As<IClientService>();
        }
    }
}
