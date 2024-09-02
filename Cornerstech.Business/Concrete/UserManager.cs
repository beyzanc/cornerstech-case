using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _UserDal;
        private readonly IUnitOfWorkDal _uowDal;

        public UserManager(IUnitOfWorkDal uowDal, IUserDal UserDal)
        {
            _uowDal = uowDal;
            _UserDal = UserDal;
        }

        public void TDelete(User t)
        {
            _UserDal.Delete(t);
            _uowDal.Save();
        }

        public User TGetByID(int id)
        {
            return _UserDal.GetByID(id);
        }

        public IQueryable<User> TGetList()
        {
            return _UserDal.GetQueryableList();
        }

        public void TInsert(User t)
        {
            _UserDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<User> t)
        {
            _UserDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(User t)
        {
            _UserDal.Update(t);
            _uowDal.Save();
        }

        public User GetByName(string username)
        {
            return _UserDal.GetQueryableList().FirstOrDefault(x => x.UserName == username);
        }

        public bool CheckPasswordByName(string username, string password)
        {
            var user = GetByName(username);
            if (user == null)
            {
                return false;
            }

            return user.Password == password;
        }

        public string GetUserRole(string username)
        {
            var user = GetByName(username);
            return user?.Role;
        }
    }
}
