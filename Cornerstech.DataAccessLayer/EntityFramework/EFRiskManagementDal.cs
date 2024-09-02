using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;
using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFRiskManagementDal : GenericRepository<RiskManagement>, IRiskManagementDal
    {
        public EFRiskManagementDal(Context context) : base(context)
        {
        }
    }
}
