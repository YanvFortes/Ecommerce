namespace Ecommerce.DAO.Entities;

public partial class Cupom
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;
    public string Tipodesconto { get; set; } = null!;
    public decimal Valor { get; set; }
    public DateTime Datacadastro { get; set; }
    public DateTime Dataexpiracao { get; set; }
    public bool Ativo { get; set; }
    public virtual List<Pedido> Pedidos { get; set; } = new();
}
