using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;

namespace Cornerstech.DataAccessLayer.UnitOfWork.Concrete
{
    public class UnitOfWorkDal : IUnitOfWorkDal
    {
        private readonly Context _context;

        public UnitOfWorkDal(Context context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
