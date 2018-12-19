namespace ClientManager.Web
{
    public class DIModule : Module
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientController>();            
        }
    }
}
