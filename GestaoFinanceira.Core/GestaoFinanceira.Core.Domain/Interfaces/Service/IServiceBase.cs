using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Core.Domain.Interfaces.Service
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : class
    {
        Task InsertAsync(TEntity obj);

        Task<TEntity> GetByIdAsync(Guid id);

        Task<List<TEntity>> GetAllAsync();

        Task UpdateAsync(TEntity obj);

        Task DeleteAsync(TEntity obj);
    }
}
