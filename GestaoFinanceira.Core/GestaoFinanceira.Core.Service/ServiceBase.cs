using GestaoFinanceira.Core.Domain.Interfaces.Repository;
using GestaoFinanceira.Core.Domain.Interfaces.Service;

namespace GestaoFinanceira.Core.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private IRepositoryBase<TEntity> _repository { get; }

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task DeleteAsync(TEntity obj)
        {
            await _repository.DeleteAsync(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task InsertAsync(TEntity obj)
        {
            await _repository.InsertAsync(obj);
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            await _repository.UpdateAsync(obj);
        }
    }
}
