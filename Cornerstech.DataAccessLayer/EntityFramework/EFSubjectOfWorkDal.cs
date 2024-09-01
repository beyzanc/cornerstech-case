using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornerstech.DataAccessLayer.EntityFramework
{
    public class EFSubjectOfWorkDal : GenericRepository<SubjectOfWork>, ISubjectOfWorkDal
    {
        public EFSubjectOfWorkDal(Context context) : base(context)
        {
        }
    }
}
