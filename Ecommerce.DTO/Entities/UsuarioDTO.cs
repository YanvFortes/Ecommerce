using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTO.Entities;

public class UsuarioDTO
{
    public int Id { get; set; }

    [Required, StringLength(120)]
    public string Nome { get; set; } = string.Empty;
    public string Documento { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public bool Ativo { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataEdicao { get; set; }
    public List<EnderecoDTO> Enderecos { get; set; }
}
