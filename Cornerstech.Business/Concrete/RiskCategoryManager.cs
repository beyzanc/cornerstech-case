using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class RiskCategoryManager : IRiskCategoryService
    {
        private readonly IRiskCategoryDal _RiskCategoryDal;
        private readonly IUnitOfWorkDal _uowDal;

        public RiskCategoryManager(IUnitOfWorkDal uowDal, IRiskCategoryDal RiskCategoryDal)
        {
            _uowDal = uowDal;
            _RiskCategoryDal = RiskCategoryDal;
        }

        public void TDelete(RiskCategory t)
        {
            _RiskCategoryDal.Delete(t);
            _uowDal.Save();
        }

        public RiskCategory TGetByID(int id)
        {
            return _RiskCategoryDal.GetByID(id);
        }

        public IQueryable<RiskCategory> TGetList()
        {
            return _RiskCategoryDal.GetQueryableList();
        }

        public void TInsert(RiskCategory t)
        {
            _RiskCategoryDal.Insert(t);
            _uowDal.Save();
        }


        public void TUpdate(RiskCategory t)
        {
            _RiskCategoryDal.Update(t);
            _uowDal.Save();
        }
    }

}
