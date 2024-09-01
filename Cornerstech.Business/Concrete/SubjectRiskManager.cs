using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;
using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class SubjectRiskManager : ISubjectRiskService
    {
        private readonly ISubjectRiskDal _subjectRiskDal;
        private readonly IUnitOfWorkDal _uowDal;

        public SubjectRiskManager(IUnitOfWorkDal uowDal, ISubjectRiskDal SubjectRiskDal)
        {
            _uowDal = uowDal;
            _subjectRiskDal = SubjectRiskDal;
        }

        public void TDelete(SubjectRisk t)
        {
            _subjectRiskDal.Delete(t);
            _uowDal.Save();
        }

        public SubjectRisk TGetByID(int id)
        {
            return _subjectRiskDal.GetByID(id);
        }

        public IQueryable<SubjectRisk> TGetList()
        {
            return _subjectRiskDal.GetQueryableList();
        }

        public void TInsert(SubjectRisk t)
        {
            _subjectRiskDal.Insert(t);
            _uowDal.Save();
        }


        public void TUpdate(SubjectRisk t)
        {
            _subjectRiskDal.Update(t);
            _uowDal.Save();
        }
    }

}
