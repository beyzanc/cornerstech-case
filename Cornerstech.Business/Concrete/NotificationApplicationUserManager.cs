using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;
using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class NotificationApplicationUserManager : INotificationApplicationUserService
    {
        private readonly INotificationApplicationUserDal _notificationApplicationUserDal;
        private readonly IUnitOfWorkDal _uowDal;

        public NotificationApplicationUserManager(IUnitOfWorkDal uowDal, INotificationApplicationUserDal NotificationApplicationUserDal)
        {
            _uowDal = uowDal;
            _notificationApplicationUserDal = NotificationApplicationUserDal;
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
