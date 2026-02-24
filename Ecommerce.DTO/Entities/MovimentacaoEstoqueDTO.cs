namespace Ecommerce.DTO.Entities;

public class MovimentacaoEstoqueDTO
{
    public int Id { get; set; }
    public int Estoqueid { get; set; }
    public string Tipo { get; set; } = null!;
    public int Quantidade { get; set; }
    public string? Referencia { get; set; }
    public DateTime Datacadastro { get; set; }
}