namespace Ecommerce.DTO.Entities;

public class CupomDTO
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public string TipoDesconto { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataExpiracao { get; set; }
}
