using ClientManager.Data.Constants;

namespace ClientManager.Domain.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public decimal AvailableMoney { get; set; }
        public GenderType? Gender { get; set; }
    }
}
