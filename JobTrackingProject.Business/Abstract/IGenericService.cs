using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace JobTrackingProject.Business.Abstract
{
    public interface IGenericService<T> where T : class, IEntity, new()
    {
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        T GetByFilter(Expression<Func<T, bool>> filter);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}