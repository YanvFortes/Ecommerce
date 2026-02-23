namespace Ecommerce.DTO.Entities;

public class CarrinhoDTO
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public List<ItemCarrinhoDTO> Itens { get; set; }
    public decimal Total { get; set; }
}
