namespace Cornerstech.EntityLayer.Entities
{
    public class NotificationApplicationUser : BaseEntity
    {        
        public Notification Notification { get; set; }
        public int NotificationId { get; set; }
        public int ApplicationUserId { get; set; }
        public User ApplicationUser { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
