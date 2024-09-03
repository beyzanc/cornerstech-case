using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;

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

        public double GetRiskValueByRiskName(string riskName)
        {
            var risk = _RiskDal.GetQueryableList().FirstOrDefault(x => x.Name == riskName);

            if (risk != null)
            {
                return (risk.Frequence ?? 0.0) * (risk.Level ?? 0.0) * (risk.Possibility ?? 0.0);
            }

            return 0.0;
        }

    }

}
