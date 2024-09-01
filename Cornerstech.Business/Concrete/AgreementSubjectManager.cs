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
    public class AgreementSubjectManager : IAgreementSubjectService
    {
        private readonly IAgreementSubjectDal _agreementSubjectDal;
        private readonly IUnitOfWorkDal _uowDal;

        public AgreementSubjectManager(IUnitOfWorkDal uowDal, IAgreementSubjectDal AgreementSubjectDal)
        {
            _uowDal = uowDal;
            _agreementSubjectDal = AgreementSubjectDal;
        }

        public void TDelete(AgreementSubject t)
        {
            _agreementSubjectDal.Delete(t);
            _uowDal.Save();
        }

        public AgreementSubject TGetByID(int id)
        {
            return _agreementSubjectDal.GetByID(id);
        }

        public IQueryable<AgreementSubject> TGetList()
        {
            return _agreementSubjectDal.GetQueryableList();
        }

        public void TInsert(AgreementSubject t)
        {
            _agreementSubjectDal.Insert(t);
            _uowDal.Save();
        }


        public void TUpdate(AgreementSubject t)
        {
            _agreementSubjectDal.Update(t);
            _uowDal.Save();
        }
    }

}
