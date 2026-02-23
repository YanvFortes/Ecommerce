namespace Ecommerce.DTO.Entities;

public class PedidoDTO
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public string Status { get; set; }
    public decimal ValorTotal { get; set; }
    public decimal ValorFrete { get; set; }
    public decimal ValorDesconto { get; set; }

    public List<ItemPedidoDTO> Itens { get; set; }
}
