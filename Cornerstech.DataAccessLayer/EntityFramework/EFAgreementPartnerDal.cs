using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFAgreementPartnerDal : GenericRepository<AgreementPartner>, IAgreementPartnerDal
    {
        public EFAgreementPartnerDal(Context context) : base(context)
        {
        }
    }
}
