using EWallet.Enums;

namespace EWallet.Entities
{
    public class Notification
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Message { get; set; } = null!;
        public NotificationType NotificationType { get; set; } // SMS, Email, Push
        public bool IsRead { get; set; }
        public DateTime SentAt { get; set; }

        public User User { get; set; }
    }
}
