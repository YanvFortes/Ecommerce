namespace Ecommerce.DTO.Entities;

public class ProdutoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public bool Ativo { get; set; }
    public List<ImagemProdutoDTO> Imagens { get; set; }
    public List<VarianteProdutoDTO> Variantes { get; set; }
}

