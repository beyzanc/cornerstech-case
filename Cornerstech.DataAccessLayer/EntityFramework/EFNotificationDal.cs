using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;
using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EFNotificationDal(Context context) : base(context)
        {
        }
    }
}
