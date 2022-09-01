using System.Linq.Expressions;

namespace PatikaClassWork1.Core.Business.Abstract
{
    public interface IService<TEntity>
    {
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>>? filter = null);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> GetById(int id);
        Task<TEntity> Add(TEntity item);
        Task<TEntity> Update(TEntity item);
        Task<bool> Delete(TEntity item);
    }
}