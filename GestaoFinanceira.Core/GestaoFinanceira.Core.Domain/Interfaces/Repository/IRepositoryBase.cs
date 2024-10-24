using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Core.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        Task InsertAsync(TEntity obj);

        Task<TEntity> GetByIdAsync(Guid id);

        Task<List<TEntity>> GetAllAsync();

        Task UpdateAsync(TEntity obj);

        Task DeleteAsync(TEntity obj);
    }
}
