using GestaoFinanceira.Core.Data.Repository;
using GestaoFinanceira.Core.Domain.Interfaces.Repository;
using Lancamentos.Data.Context;
using Lancamentos.Domain.Interfaces.Repository;
using Lancamentos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancamentos.Data.Repository
{
    public class MovimentacaoRepository : RepositoryBase<Movimentacao, ApplicationDbContext>, IMovimentacaoRepository
    {
        public MovimentacaoRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
