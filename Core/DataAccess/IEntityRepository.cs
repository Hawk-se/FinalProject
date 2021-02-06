using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Generic constraint <T>yi sınırlandırmak anlamına gelir!!!
    // T:class demek referans tip demek. T ya IEntity olabilir ya da IEntity implement eden bir nesne olabilir
    // New() : new'lenebilir olmalı (IEntity new'lenemediği için ICategoryDal'da IEntity kullanamayız !!!)
    // Bu nedenle sistemimiz sadece veri tabanı nesneleri ile çalışan bir repository oldu !!! Category, Customer, Product!!!
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
