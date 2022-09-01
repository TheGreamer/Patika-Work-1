using PatikaClassWork1.Core.Entity.Concrete;
using System.Linq.Expressions;

namespace PatikaClassWork1.Core.DataAccess.Abstract
{
    public interface IEfRepository<TEntity> where TEntity : CoreEntity, new()
    {
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>>? filter = null);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}