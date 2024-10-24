using System.ComponentModel.DataAnnotations;

namespace Lancamentos.Api.Request
{
    public class InsereMovimentacaoRequest
    {
        /// <summary>
        /// Valor da movimentação
        /// </summary>
        [Required]
        public decimal Valor { get; set; }

        /// <summary>
        /// Data da movimentação
        /// </summary>
        [Required]
        public DateTime Data { get; set; }
    }
}
