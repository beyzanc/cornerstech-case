using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;
using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFNotificationApplicationUserDal : GenericRepository<NotificationApplicationUser>, INotificationApplicationUserDal
    {
        public EFNotificationApplicationUserDal(Context context) : base(context)
        {
        }
    }
}
