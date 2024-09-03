using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFSubjectOfWorkDal : GenericRepository<SubjectOfWork>, ISubjectOfWorkDal
    {
        public EFSubjectOfWorkDal(Context context) : base(context)
        {
        }
    }
}
