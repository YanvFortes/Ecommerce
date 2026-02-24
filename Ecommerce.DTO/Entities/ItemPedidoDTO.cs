namespace Ecommerce.DTO.Entities;

public class ItemPedidoDTO
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public string NomeProduto { get; set; } = string.Empty;
    public string Variante { get; set; } = string.Empty;
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
    public decimal Total { get; set; }
}
