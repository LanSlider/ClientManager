using Autofac;
using ClientManager.Data.Constants;
using ClientManager.Data.Entities;
using ClientManager.Data.Repositories;
using ClientManager.Domain.Services;
using ClientManager.xUnitTests.Domain.Service;
using Moq;
using System;
using Xunit;

namespace ClientManager.XUnitTests.Domain.Service
{
    public class ClientServiceTests : BaseTests
    {
        private readonly ClientEntity _client;

        private IClientService _clientService;
        private readonly Mock<IClientRepository> _clientRepositoryMock = new Mock<IClientRepository>();  


        public ClientServiceTests()
            : base()
        {
            _client = new ClientEntity() { Id = 1, UserName = "Alex", Gender = GenderType.Male, AvailableMoney = 100 };
       
            _clientService = Container.Resolve<IClientService>();                            
        }

        protected override void RegisterInstancesInBuilder(ContainerBuilder builder)
        {
            builder.RegisterInstance(_clientRepositoryMock.Object).As<IClientRepository>();
        }

        [Fact]
        public void Create_creates_new_client()
        {
            // Arrange, Act
            _clientService.Create(_client);
            
            // Assert
            _clientRepositoryMock.Verify(repository => repository.Create(It.Is<ClientEntity>(clientToCreate => clientToCreate.UserName == _client.UserName && clientToCreate.AvailableMoney == _client.AvailableMoney)), Times.Once);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(100)]
        public void Create_sets_id_by_repository(int clientId)
        {
            // Arrange
            var expectedClientId = 8;
            _client.Id = clientId;
            _clientRepositoryMock.Setup(repository => repository.Create(_client)).Callback<ClientEntity>(clientToCreate => clientToCreate.Id = expectedClientId);

            // Act
            _clientService.Create(_client);

            // Assert
            Assert.Equal(expectedClientId, _client.Id);
        }

        [Fact]
        public void Create_throws_ApplicationException_if_user_is_null()
        {
            // Arrange
            _clientRepositoryMock.Setup(repository => repository.Create(_client));

            // Act, Assert
            Assert.Throws<ApplicationException>(() => _clientService.Create(_client));
        }

        [Fact]
        public void Update_returns_updated_user()
        {
            // Arrange, Act          
            _clientService.Update(_client);

            // Assert
            _clientRepositoryMock.Verify(repository => repository.Update(_client), Times.Once);
        }

        [Fact]
        public void GetUserById_returns_user_by_user_id()
        {
            // Arrange
            var idClient = 1;
            _clientRepositoryMock.Setup(repository => repository.GetClientById(idClient)).Returns(_client);

            // Act
            var resultUser = _clientService.GetClientById(idClient);

            // Assert
            Assert.NotNull(resultUser);
            Assert.Equal(idClient, resultUser.Id);
        }
    }
}
