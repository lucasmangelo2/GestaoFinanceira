namespace Lancamentos.Api.Response
{
    public class MovimentacaoResponse
    {
        /// <summary>
        /// Id do lançamento
        /// </summary>
        public Guid Id { get; set; }

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
