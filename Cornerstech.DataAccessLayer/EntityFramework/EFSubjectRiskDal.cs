using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;
using Cornerstech.EntityLayer.Entities;


namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFSubjectRiskDal : GenericRepository<SubjectRisk>, ISubjectRiskDal
    {
        public EFSubjectRiskDal(Context context) : base(context)
        {
        }
    }
}
