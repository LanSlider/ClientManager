using System;
using ClientManager.Data.Constants;
using ClientManager.Data.Entities;
using Xunit;

namespace ClientManager.XUnitTests.Domain.Service
{
    public class ClientTests
    {
        private readonly ClientEntity _client;

        public ClientTests()
        {
            _client = new ClientEntity() { Id = 1, AvailableMoney = 100 };
        }


        [Fact]
        public void CheckCanBuy_throws_ApplicationException_for_null_gender()
        {
            // Arrange
            _client.Gender = null;
            var amount = 60;

            // Act, Assert
            Assert.Throws<ApplicationException>(() => _client.CheckCanBuy(amount));
        }

        [Theory]
        [InlineData(GenderType.Male, 51, false)]
        [InlineData(GenderType.Male, 50, true)]
        [InlineData(GenderType.Female, 81, false)]
        [InlineData(GenderType.Female, 80, true)]
        public void CheckCanBuy_returns_expected_result(GenderType gender, decimal amount, bool expectedResult)
        {
            // Arrange
            _client.Gender = gender;
            _client.AvailableMoney = 100;

            // Act
            var actualResult = _client.CheckCanBuy(amount);

            // Assert        
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
