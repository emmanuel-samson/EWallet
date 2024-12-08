namespace EWallet.Entities
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }

    }
}
