using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFAgreementSubjectDal : GenericRepository<AgreementSubject>, IAgreementSubjectDal
    {
        public EFAgreementSubjectDal(Context context) : base(context)
        {
        }
    }
}
