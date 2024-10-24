using GestaoFinanceira.Core.Service;
using Lancamentos.Domain.Interfaces.Repository;
using Lancamentos.Domain.Interfaces.Service;
using Lancamentos.Domain.Models;

namespace Lancamentos.Service
{
    public class MovimentacaoService : ServiceBase<Movimentacao>, IMovimentacaoService
    {
        public MovimentacaoService(IMovimentacaoRepository repository) : base(repository)
        {
        }
    }
}
