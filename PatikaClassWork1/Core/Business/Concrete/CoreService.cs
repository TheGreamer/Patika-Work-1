using PatikaClassWork1.Core.Business.Abstract;
using PatikaClassWork1.Core.DataAccess.Abstract;
using PatikaClassWork1.Core.Entity.Concrete;
using System.Linq.Expressions;

namespace PatikaClassWork1.Core.Business.Concrete
{
    public class CoreService<TEntity, TDal> : ICoreService<TEntity, TDal>
        where TEntity : CoreEntity, new()
        where TDal : IEfRepository<TEntity>
    {
        private readonly TDal _dal;

        public CoreService(TDal dal)
        {
            _dal = dal;
        }

        public virtual async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            return filter == null
                ? await _dal.GetAll()
                : await _dal.GetAll(filter);
        }

        public virtual async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _dal.Get(filter);
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await _dal.Get(entity => entity.Id == id);
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            return await _dal.Add(entity);
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            return await _dal.Update(entity);
        }

        public virtual async Task<bool> Delete(TEntity entity)
        {
            await _dal.Delete(entity);
            return true;
        }
    }
}