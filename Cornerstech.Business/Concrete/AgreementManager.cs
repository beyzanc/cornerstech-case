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
    public class AgreementManager : IAgreementService
    {
        private readonly IAgreementDal _AgreementDal;
        private readonly IUnitOfWorkDal _uowDal;

        public AgreementManager(IUnitOfWorkDal uowDal, IAgreementDal AgreementDal)
        {
            _uowDal = uowDal;
            _AgreementDal = AgreementDal;
        }

        public void TDelete(Agreement t)
        {
            _AgreementDal.Delete(t);
            _uowDal.Save();
        }

        public Agreement TGetByID(int id)
        {
            return _AgreementDal.GetByID(id);
        }

        public IQueryable<Agreement> TGetList()
        {
            return _AgreementDal.GetQueryableList(); 
        }

        public void TInsert(Agreement t)
        {
            _AgreementDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Agreement t)
        {
            _AgreementDal.Update(t);
            _uowDal.Save();
        }
    }
}
