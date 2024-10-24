using GestaoFinanceira.Core.Domain.Interfaces.Repository;
using GestaoFinanceira.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoFinanceira.Core.Data.Repository
{
    public class RepositoryBase<TEntity, TDbContext> : IRepositoryBase<TEntity> where TEntity : EntityBase where TDbContext : DbContext
    {
        public TDbContext Context { get; }

        public RepositoryBase(TDbContext context)
        {
            Context = context;
        }

        public Task DeleteAsync(TEntity obj)
        {
            return Task.Run(() =>
            {
                Context.Set<TEntity>().Remove(obj);
            });
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return Task.Run(() =>
            {
                return Context.Set<TEntity>().ToList();
            });
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            return Task.Run(() =>
            {
                return Context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
            });
        }

        public Task InsertAsync(TEntity obj)
        {
            return Task.Run(() =>
            {
                return Context.Set<TEntity>().Add(obj);
            });
        }

        public Task UpdateAsync(TEntity obj)
        {
            return Task.Run(() =>
            {
                return Context.Set<TEntity>().Update(obj);
            });
        }
    }
}
