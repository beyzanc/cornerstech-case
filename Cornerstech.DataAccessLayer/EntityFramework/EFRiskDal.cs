using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFRiskDal : GenericRepository<Risk>, IRiskDal
    {
        public EFRiskDal(Context context) : base(context)
        {
        }
    }
}
