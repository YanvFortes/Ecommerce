namespace Ecommerce.DTO.Entities;

public class EnderecoDTO
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public string Rua { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Complemento { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public string Pais { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
    public bool EhPadrao { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataEdicao { get; set; }
}
