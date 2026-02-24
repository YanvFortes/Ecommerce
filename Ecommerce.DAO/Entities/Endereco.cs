namespace Ecommerce.DAO.Entities;

public partial class Endereco
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
    public bool Ehpadrao { get; set; }
    public DateTime Datacadastro { get; set; }
    public DateTime Dataedicao { get; set; }
}
