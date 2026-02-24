namespace Ecommerce.DAO.Entities;

public partial class Itemcarrinho
{
    public int Id { get; set; }
    public int Carrinhoid { get; set; }
    public int Varianteid { get; set; }
    public int Quantidade { get; set; }
    public decimal Precounitario { get; set; }
    public virtual Carrinho Carrinho { get; set; } = null!;
    public virtual Varianteproduto Variante { get; set; } = null!;
}
