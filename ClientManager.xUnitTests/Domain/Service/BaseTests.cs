using System;
using Autofac;
using ClientManager.Data.Repositories;
using ClientManager.Domain;
using Moq;

namespace ClientManager.xUnitTests.Domain.Service
{
    public abstract class BaseTests
    {
        protected IContainer Container { get; private set; }

        protected BaseTests()
        { 
            var builder = new ContainerBuilder();
            DIModule.Load(builder);
            RegisterInstancesInBuilder(builder);

            Container = builder.Build();
        }

        protected virtual void RegisterInstancesInBuilder(ContainerBuilder builder)
        {

        }
    }
}
