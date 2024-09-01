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
    public class AgreementPartnerManager : IAgreementPartnerService
    {
        private readonly IAgreementPartnerDal _agreementPartnerDal;
        private readonly IUnitOfWorkDal _uowDal;

        public AgreementPartnerManager(IUnitOfWorkDal uowDal, IAgreementPartnerDal AgreementPartnerDal)
        {
            _uowDal = uowDal;
            _agreementPartnerDal = AgreementPartnerDal;
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
    }

}
