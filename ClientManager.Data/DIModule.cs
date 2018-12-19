using Autofac;
using ClientManager.Data.Repositories;
using Module = System.Reflection.Module;

namespace ClientManager.Data
{
    public class DIModule : Module
    {
        public static void Load(ContainerBuilder builder)
        {           
            builder.RegisterType<ClientRepository>().As<IClientRepository>();
        }     
    }
}
