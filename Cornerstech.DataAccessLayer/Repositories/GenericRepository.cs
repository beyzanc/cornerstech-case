using Cornerstech.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornerstech.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class // Generic repository implementing CRUD operations using Entity Framework for any entity type.

    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetQueryableList()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Insert(T t)
        {
            _context.Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);
        }

        public void Update(T t)
        {
            _context.Update(t);
        }
    }
}
