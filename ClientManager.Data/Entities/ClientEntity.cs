using ClientManager.Data.Constants;
using Microsoft.AspNetCore.Identity;
using System;

namespace ClientManager.Data.Entities
{
    public class ClientEntity : IdentityUser<int>
    {
        public decimal AvailableMoney { get; set; }
        public GenderType? Gender { get; set; }

        public bool CheckCanBuy(decimal amount)
        {
            if (Gender == null)
            {
                throw new ApplicationException("Gender is null");
            }

            if ((Gender == GenderType.Male && amount <= AvailableMoney / 2) ||
                (Gender == GenderType.Female && amount <= AvailableMoney * Convert.ToDecimal(0.8)))
            {
                return true;
            }

            return false;
        }
    }

    public class RoleEntity : IdentityRole<int>
    {
        public RoleEntity()
        { }

        public RoleEntity(string name) { Name = name; }
    }
}
