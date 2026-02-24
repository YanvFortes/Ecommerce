namespace Ecommerce.DAO.Entities;

public partial class Atributovariante
{
    public int Id { get; set; }
    public int Varianteid { get; set; }
    public string Nome { get; set; } = null!;
    public string Valor { get; set; } = null!;

    public virtual Varianteproduto Variante { get; set; } = null!;
}
