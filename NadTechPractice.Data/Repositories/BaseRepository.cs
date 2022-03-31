using Microsoft.EntityFrameworkCore;

using NadTechPractice.Contracts.Repositories;
using NadTechPractice.Entities.Commons;

using System.Linq;

namespace NadTechPractice.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        private readonly NadTechPracticeContext _ctx;
        public BaseRepository(NadTechPracticeContext ctx)
        {
            _ctx = ctx;
        }
        public void Create(T entity)
        {
            _ctx.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
        }

        public System.Linq.IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges ? _ctx.Set<T>() : _ctx.Set<T>().AsNoTracking();
        }

        public System.Linq.IQueryable<T> FindByCondition(System.Linq.Expressions.Expression<System.Func<T, bool>> expression, bool trackChanges)
        {
            return trackChanges ? _ctx.Set<T>().Where(expression) : _ctx.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            _ctx.Set<T>().Update(entity);
        }
    }
}
