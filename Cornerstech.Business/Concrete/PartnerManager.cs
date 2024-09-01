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
    public class PartnerManager : IPartnerService
    {
        private readonly IPartnerDal _PartnerDal;
        private readonly IUnitOfWorkDal _uowDal;

        public PartnerManager(IUnitOfWorkDal uowDal, IPartnerDal PartnerDal)
        {
            _uowDal = uowDal;
            _PartnerDal = PartnerDal;
        }

        public void TDelete(Partner t)
        {
            _PartnerDal.Delete(t);
            _uowDal.Save();
        }

        public Partner TGetByID(int id)
        {
            return _PartnerDal.GetByID(id);
        }

        public IQueryable<Partner> TGetList()
        {
            return _PartnerDal.GetQueryableList();
        }

        public void TInsert(Partner t)
        {
            _PartnerDal.Insert(t);
            _uowDal.Save();
        }


        public void TUpdate(Partner t)
        {
            _PartnerDal.Update(t);
            _uowDal.Save();
        }
    }

}
