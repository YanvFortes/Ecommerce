namespace Ecommerce.DAO.Entities;

public partial class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public int? Categoriapaiid { get; set; }
    public virtual Categoria? Categoriapai { get; set; }
    public virtual List<Categoria> Subcategorias { get; set; } = new();
}