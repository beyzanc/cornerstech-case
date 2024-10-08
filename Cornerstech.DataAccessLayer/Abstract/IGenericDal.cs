﻿namespace Cornerstech.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // Generic interface for CRUD operations on any entity type.
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        IQueryable<T> GetQueryableList();
        T GetByID(int id);
        void MultiUpdate(List<T> t);
    }
}
