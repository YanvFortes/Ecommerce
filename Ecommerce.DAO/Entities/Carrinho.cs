namespace Ecommerce.DAO.Entities;

public partial class Carrinho
{
    public int Id { get; set; }
    public int Usuarioid { get; set; }
    public decimal Total { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
    public virtual List<Itemcarrinho> Itens { get; set; } = new();
}
