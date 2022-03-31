using System.Linq.Expressions;
using System.Linq;
using System;

namespace NadTechPractice.Contracts.Repositories
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
