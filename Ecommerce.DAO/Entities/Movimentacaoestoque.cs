namespace Ecommerce.DAO.Entities;

public partial class Movimentacaoestoque
{
    public int Id { get; set; }
    public int Estoqueid { get; set; }
    public string Tipo { get; set; } = null!;
    public int Quantidade { get; set; }
    public string? Referencia { get; set; }
    public DateTime Datacadastro { get; set; }
    public virtual Estoque Estoque { get; set; } = null!;
}
