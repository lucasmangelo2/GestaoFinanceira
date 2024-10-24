using GestaoFinanceira.Core.Domain.Interfaces.Repository;
using Lancamentos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancamentos.Domain.Interfaces.Repository
{
    public interface IMovimentacaoRepository : IRepositoryBase<Movimentacao>
    {
    }
}
