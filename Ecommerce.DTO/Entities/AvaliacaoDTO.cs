namespace Ecommerce.DTO.Entities;

public class AvaliacaoDTO
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public int UsuarioId { get; set; }
    public int Nota { get; set; }
    public string Comentario { get; set; } = string.Empty;
    public DateTime DataCadastro { get; set; }
}