using Microsoft.EntityFrameworkCore;
using PatikaClassWork1.Core.DataAccess.Abstract;
using PatikaClassWork1.Core.Entity.Concrete;
using System.Linq.Expressions;

namespace PatikaClassWork1.Core.DataAccess.Concrete
{
    public class EfRepository<TEntity, TContext> : IEfRepository<TEntity>
        where TEntity : CoreEntity, new()
        where TContext : DbContext, new()
    {
        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using TContext context = new();
            return filter == null
                ? await context.Set<TEntity>().ToListAsync()
                : await context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new();
            return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            using TContext context = new();
            context.Entry(entity).State = EntityState.Added;
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            using TContext context = new();
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(TEntity entity)
        {
            using TContext context = new();
            context.Entry(entity).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }
    }
}