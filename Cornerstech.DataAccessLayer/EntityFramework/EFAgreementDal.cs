using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFAgreementDal : GenericRepository<Agreement>, IAgreementDal
    {
        public EFAgreementDal(Context context) : base(context)
        {
        }
    }
}
