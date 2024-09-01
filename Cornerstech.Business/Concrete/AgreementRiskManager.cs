using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;
using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class AgreementRiskManager : IAgreementRiskService
    {
        private readonly IAgreementRiskDal _agreementRiskDal;
        private readonly IUnitOfWorkDal _uowDal;

        public AgreementRiskManager(IUnitOfWorkDal uowDal, IAgreementRiskDal AgreementRiskDal)
        {
            _uowDal = uowDal;
            _agreementRiskDal = AgreementRiskDal;
        }

        public void TDelete(AgreementRisk t)
        {
            _agreementRiskDal.Delete(t);
            _uowDal.Save();
        }

        public AgreementRisk TGetByID(int id)
        {
            return _agreementRiskDal.GetByID(id);
        }

        public IQueryable<AgreementRisk> TGetList()
        {
            return _agreementRiskDal.GetQueryableList();
        }

        public void TInsert(AgreementRisk t)
        {
            _agreementRiskDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(AgreementRisk t)
        {
            _agreementRiskDal.Update(t);
            _uowDal.Save();
        }
    }

}
