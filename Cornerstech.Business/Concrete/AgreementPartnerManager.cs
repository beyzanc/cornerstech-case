using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class AgreementPartnerManager : IAgreementPartnerService
    {
        private readonly IAgreementPartnerDal _agreementPartnerDal;
        private readonly IPartnerDal _partnerDal;
        private readonly IUnitOfWorkDal _uowDal;

        public AgreementPartnerManager(IUnitOfWorkDal uowDal, IAgreementPartnerDal AgreementPartnerDal, IPartnerDal partnerDal)
        {
            _uowDal = uowDal;
            _agreementPartnerDal = AgreementPartnerDal;
            _partnerDal = partnerDal;
        }

        public void TDelete(AgreementPartner t)
        {
            _agreementPartnerDal.Delete(t);
            _uowDal.Save();
        }

        public AgreementPartner TGetByID(int id)
        {
            return _agreementPartnerDal.GetByID(id);
        }

        public IQueryable<AgreementPartner> TGetList()
        {
            return _agreementPartnerDal.GetQueryableList();
        }

        public void TInsert(AgreementPartner t)
        {
            _agreementPartnerDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(AgreementPartner t)
        {
            _agreementPartnerDal.Update(t);
            _uowDal.Save();
        }

        public int GetPartnerCountWithAgreements()
        {
            var distinctPartnerCount = (from ap in _agreementPartnerDal.GetQueryableList()
                                        join p in _partnerDal.GetQueryableList()
                                        on ap.PartnerId equals p.Id
                                        select ap.PartnerId)
                                        .Distinct()
                                        .Count();

            return distinctPartnerCount;
        }

    }

}
