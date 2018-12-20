using Autofac;
using ClientManager.Domain;

namespace ClientManager.xUnitTests.Domain.Service
{
    public abstract class BaseTests
    {
        private IContainer _container;
        protected IContainer Container {
            get
            {
                if (_container == null)
                {
                    var builder = new ContainerBuilder();
                    DIModule.Load(builder);
                    RegisterInstancesInBuilder(builder);
                    _container = builder.Build();
                }

                return _container;
            }
        }
      
        protected virtual void RegisterInstancesInBuilder(ContainerBuilder builder)
        {

        }
    }
}
