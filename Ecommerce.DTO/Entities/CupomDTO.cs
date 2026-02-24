namespace Ecommerce.DTO.Entities;

public class CupomDTO
{
    public int Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string TipoDesconto { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataExpiracao { get; set; }
}
