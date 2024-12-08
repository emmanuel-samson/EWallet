using EWallet.Enums;

namespace EWallet.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; } // Paystack, Bank Transfer
        public PaymentStatus PaymentStatus { get; set; } // Pending, Completed, Failed
        public Guid Reference { get; set; } // Paystack Transaction Reference
        public DateTime PaymentDate { get; set; }

        public User User { get; set; }
    }
}
