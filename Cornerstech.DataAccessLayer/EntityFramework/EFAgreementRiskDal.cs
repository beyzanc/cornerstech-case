using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;
using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFAgreementRiskDal : GenericRepository<AgreementRisk>, IAgreementRiskDal
    {
        public EFAgreementRiskDal(Context context) : base(context)
        {
        }
    }
}
