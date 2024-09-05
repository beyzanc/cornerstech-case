using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface INotificationApplicationUserService : IGenericService<NotificationApplicationUser>
    {
        List<NotificationApplicationUser> GetUserNotifications(int userId);
    }
}
