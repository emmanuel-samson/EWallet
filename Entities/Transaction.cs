using EWallet.Enums;

namespace EWallet.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; } // Deposit, Withdrawal, Transfer, Payment
        public TransactionStatus Status { get; set; } // Pending, Completed, Failed
        public DateTime TransactionDate { get; set; }
        public Guid Reference { get; set; } // Unique Transaction Reference
        public string Description { get; set; } = null!;

        public Wallet Wallet { get; set; }
    }
}
