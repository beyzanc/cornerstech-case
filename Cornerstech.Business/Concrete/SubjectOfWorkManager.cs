using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class SubjectOfWorkManager : ISubjectOfWorkService
    {
        private readonly ISubjectOfWorkDal _SubjectOfWorkDal;
        private readonly IUnitOfWorkDal _uowDal;

        public SubjectOfWorkManager(IUnitOfWorkDal uowDal, ISubjectOfWorkDal SubjectOfWorkDal)
        {
            _uowDal = uowDal;
            _SubjectOfWorkDal = SubjectOfWorkDal;
        }

        public void TDelete(SubjectOfWork t)
        {
            _SubjectOfWorkDal.Delete(t);
            _uowDal.Save();
        }

        public SubjectOfWork TGetByID(int id)
        {
            return _SubjectOfWorkDal.GetByID(id);
        }

        public IQueryable<SubjectOfWork> TGetList()
        {
            return _SubjectOfWorkDal.GetQueryableList();
        }

        public void TInsert(SubjectOfWork t)
        {
            _SubjectOfWorkDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(SubjectOfWork t)
        {
            _SubjectOfWorkDal.Update(t);
            _uowDal.Save();
        }
    }

}
