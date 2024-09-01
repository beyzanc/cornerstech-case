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
    public class EFRiskCategoryDal : GenericRepository<RiskCategory>, IRiskCategoryDal
    {
        public EFRiskCategoryDal(Context context) : base(context)
        {
        }
    }
}
