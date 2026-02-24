using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ecommerce.DTO.Entities;

public class UsuarioDTO
{
    public int Id { get; set; }
    [Required, StringLength(120)] public string Nome { get; set; } = string.Empty;
    public string Documento { get; set; } = string.Empty;
    [Required, EmailAddress] public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public string TipoUsuario {  get; set; } = string.Empty;
    public int TipoUsuarioId { get; set; }
    public string? Senha { get; set; }
    [JsonIgnore] public string? SenhaConfirma { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataEdicao { get; set; }
    public List<EnderecoDTO> Enderecos { get; set; }
}
