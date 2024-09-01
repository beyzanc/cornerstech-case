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
    public class RiskManager : IRiskService
    {
        private readonly IRiskDal _RiskDal;
        private readonly IUnitOfWorkDal _uowDal;

        public RiskManager(IUnitOfWorkDal uowDal, IRiskDal RiskDal)
        {
            _uowDal = uowDal;
            _RiskDal = RiskDal;
        }

        public void TDelete(Risk t)
        {
            _RiskDal.Delete(t);
            _uowDal.Save();
        }

        public Risk TGetByID(int id)
        {
            return _RiskDal.GetByID(id);
        }

        public IQueryable<Risk> TGetList()
        {
            return _RiskDal.GetQueryableList();
        }

        public void TInsert(Risk t)
        {
            _RiskDal.Insert(t);
            _uowDal.Save();
        }


        public void TUpdate(Risk t)
        {
            _RiskDal.Update(t);
            _uowDal.Save();
        }
    }

}
