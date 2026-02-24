namespace Ecommerce.DAO.Entities;

public partial class Imagemproduto
{
    public int Id { get; set; }
    public int Produtoid { get; set; }
    public string Urlimagem { get; set; } = null!;
    public bool Principal { get; set; }
    public virtual Produto Produto { get; set; } = null!;
}
