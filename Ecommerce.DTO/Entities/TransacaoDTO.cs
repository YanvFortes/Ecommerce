namespace Ecommerce.DTO.Entities;

public class TransacaoDTO
{
    public int Id { get; set; }
    public int PedidoId { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataPagamento { get; set; }
}
