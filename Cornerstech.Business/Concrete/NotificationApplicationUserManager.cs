using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;
using Cornerstech.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class NotificationApplicationUserManager : INotificationApplicationUserService // Service responsible for creating and managing notifications, triggered by updates to agreements or risks

    {
        private readonly INotificationApplicationUserDal _notificationApplicationUserDal;
        private readonly IUnitOfWorkDal _uowDal;

        public NotificationApplicationUserManager(IUnitOfWorkDal uowDal, INotificationApplicationUserDal NotificationApplicationUserDal)
        {
            _uowDal = uowDal;
            _notificationApplicationUserDal = NotificationApplicationUserDal;
        }

        public List<NotificationApplicationUser> GetUserNotifications(int userId) // Retrieves all notifications for a given user, filtered by their ID

        {
            return _notificationApplicationUserDal.GetQueryableList().Where(u => u.ApplicationUserId.Equals(userId))
                                            .ToList();
        }

        public void TDelete(NotificationApplicationUser t)
        {
            _notificationApplicationUserDal.Delete(t);
            _uowDal.Save();
        }

        public NotificationApplicationUser TGetByID(int id)
        {
            return _notificationApplicationUserDal.GetByID(id);
        }

        public IQueryable<NotificationApplicationUser> TGetList()
        {
            return _notificationApplicationUserDal.GetQueryableList();
        }

        public void TInsert(NotificationApplicationUser t)
        {
            _notificationApplicationUserDal.Insert(t);
            _uowDal.Save();
        }


        public void TUpdate(NotificationApplicationUser t)
        {
            _notificationApplicationUserDal.Update(t);
            _uowDal.Save();
        }
    }
}
