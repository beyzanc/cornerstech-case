using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class RiskManagementManager : IRiskManagementService
    {
        private readonly IRiskManagementDal _RiskManagementDal;
        private readonly IUnitOfWorkDal _uowDal;

        public RiskManagementManager(IUnitOfWorkDal uowDal, IRiskManagementDal RiskManagementDal)
        {
            _uowDal = uowDal;
            _RiskManagementDal = RiskManagementDal;
        }

        public void TDelete(RiskManagement t)
        {
            _RiskManagementDal.Delete(t);
            _uowDal.Save();
        }

        public RiskManagement TGetByID(int id)
        {
            return _RiskManagementDal.GetByID(id);
        }

        public IQueryable<RiskManagement> TGetList()
        {
            return _RiskManagementDal.GetQueryableList();
        }

        public void TInsert(RiskManagement t)
        {
            _RiskManagementDal.Insert(t);
            _uowDal.Save();
        }


        public void TUpdate(RiskManagement t)
        {
            _RiskManagementDal.Update(t);
            _uowDal.Save();
        }
    }

}
