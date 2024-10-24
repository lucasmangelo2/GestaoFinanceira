using GestaoFinanceira.Core.Domain.Models;

namespace Lancamentos.Domain.Models
{
    public class Movimentacao : EntityBase
    {
        /// <summary>
        /// Valor da movimentação
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Data da movimentação
        /// </summary>
        public DateTime Data { get; set; }
    }
}
