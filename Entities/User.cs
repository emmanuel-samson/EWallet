using EWallet.Enums;

namespace EWallet.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public Role Role { get; set; } // Admin, Customer, Merchant
        public DateTime CreatedAt { get; set; }
        public bool IsVerified { get; set; }
    }
}
