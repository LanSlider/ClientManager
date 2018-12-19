using System.ComponentModel.DataAnnotations;

namespace ClientManager.Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
