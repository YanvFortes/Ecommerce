namespace Ecommerce.DTO.Entities;

public class VarianteProdutoDTO
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public string Variante { get; set; }
    public decimal Preco { get; set; }
    public decimal? PrecoPromocional { get; set; }

    public EstoqueDTO Estoque { get; set; }
    public List<AtributoVarianteDTO> Atributos { get; set; }
}
