using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;
using Cornerstech.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;
        private readonly INotificationApplicationUserDal _notificationApplicationUserDal;
        private readonly IAgreementPartnerDal _agreementPartnerDal;
        private readonly IAgreementDal _agreementDal;
        private readonly IUnitOfWorkDal _uowDal;

        public NotificationManager(IUnitOfWorkDal uowDal, INotificationDal NotificationDal, IAgreementPartnerDal agreementPartnerDal, 
                                        IAgreementDal agreementDal, INotificationApplicationUserDal notificationApplicationUserDal)
        {
            _uowDal = uowDal;
            _notificationDal = NotificationDal;
            _agreementPartnerDal = agreementPartnerDal;
            _agreementDal = agreementDal;
            _notificationApplicationUserDal = notificationApplicationUserDal;
        }

        public List<NotificationApplicationUser> GetUserNotifications(int userId)
        {
            return _notificationApplicationUserDal.GetQueryableList().Where(u => u.ApplicationUserId.Equals(userId) && !u.IsRead)
                                            .Include(n => n.Notification)
                                            .ToList();
        }

        public void ReadNotification(int notificationId, int userId)
        {
            var notification = _notificationApplicationUserDal.GetQueryableList()
                                        .FirstOrDefault(n => n.ApplicationUserId.Equals(userId)
                                        && n.Id == notificationId);
            notification.IsRead = true;
            _notificationApplicationUserDal.Update(notification);
            _uowDal.Save();
        }

        public void TDelete(Notification t)
        {
            _notificationDal.Delete(t);
            _uowDal.Save();
        }

        public Notification TGetByID(int id)
        {
            return _notificationDal.GetByID(id);
        }

        public IQueryable<Notification> TGetList()
        {
            return _notificationDal.GetQueryableList();
        }

        public void TInsert(Notification t)
        {
            _notificationDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Notification t)
        {
            _notificationDal.Update(t);
            _uowDal.Save();
        }

    }
}
