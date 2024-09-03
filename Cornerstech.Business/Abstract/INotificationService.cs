using Cornerstech.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        List<NotificationApplicationUser> GetUserNotifications(int userId);
        void ReadNotification(int notificationId, int userId);
    }
}
