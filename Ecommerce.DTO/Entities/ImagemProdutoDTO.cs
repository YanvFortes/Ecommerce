namespace Ecommerce.DTO.Entities;

public class ImagemProdutoDTO
{
    public int Id { get; set; }
    public string UrlImagem { get; set; } = string.Empty;
    public bool Principal { get; set; }
}
