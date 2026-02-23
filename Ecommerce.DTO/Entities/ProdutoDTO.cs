namespace Ecommerce.DTO.Entities;

public class ProdutoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Marca { get; set; }
    public bool Ativo { get; set; }
    public List<ImagemProdutoDTO> Imagens { get; set; }
    public List<VarianteProdutoDTO> Variantes { get; set; }
}

