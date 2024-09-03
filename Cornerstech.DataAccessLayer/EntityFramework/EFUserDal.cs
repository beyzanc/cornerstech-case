using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFUserDal : GenericRepository<User>, IUserDal
    {
        public EFUserDal(Context context) : base(context)
        {
        }
    }
}
