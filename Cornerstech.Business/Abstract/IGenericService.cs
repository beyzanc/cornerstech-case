﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        IQueryable<T> TGetList(); 
        T TGetByID(int id);

    }
}
