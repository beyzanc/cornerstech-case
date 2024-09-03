using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFPartnerDal : GenericRepository<Partner>, IPartnerDal
    {
        public EFPartnerDal(Context context) : base(context)
        {
        }
    }
}
