namespace Ecommerce.DTO.Entities;

public class CategoriaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int? CategoriaPaiId { get; set; }
    public List<CategoriaDTO> SubCategorias { get; set; }
}
