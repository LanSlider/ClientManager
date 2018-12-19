using ClientManager.Data.Constants;

namespace ClientManager.Web.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public decimal AvailableMoney { get; set; }
        public GenderType? Gender { get; set; }
    }
}
