using PatikaClassWork1.Core.DataAccess.Abstract;
using PatikaClassWork1.Core.Entity.Concrete;

namespace PatikaClassWork1.Core.Business.Abstract
{
    public interface ICoreService<TEntity, TDal> : IService<TEntity>
        where TEntity : CoreEntity, new()
        where TDal : IEfRepository<TEntity>
    {
    }
}