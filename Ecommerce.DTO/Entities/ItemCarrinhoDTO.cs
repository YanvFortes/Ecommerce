namespace Ecommerce.DTO.Entities;

public class ItemCarrinhoDTO
{
    public int Id { get; set; }
    public int VarianteId { get; set; }
    public string NomeProduto { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
    public decimal Total => PrecoUnitario * Quantidade;
}
