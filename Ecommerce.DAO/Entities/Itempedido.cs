namespace Ecommerce.DAO.Entities;

public partial class Itempedido
{
    public int Id { get; set; }
    public int Pedidoid { get; set; }
    public int Produtoid { get; set; }
    public string Nomeproduto { get; set; } = null!;
    public string Variante { get; set; } = null!;
    public decimal Precounitario { get; set; }
    public int Quantidade { get; set; }
    public decimal Total { get; set; }
    public virtual Pedido Pedido { get; set; } = null!;
    public virtual Produto Produto { get; set; } = null!;
}
